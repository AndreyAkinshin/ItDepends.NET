## Description

The code:

```cs
var a1 = new KeyValuePair<int, int>(1, 2);
var a2 = new KeyValuePair<int, int>(1, 3);
Console.WriteLine(a1.GetHashCode() == a2.GetHashCode());
var b1 = new KeyValuePair<int, string>(1, "x");
var b2 = new KeyValuePair<int, string>(1, "y");
Console.WriteLine(b1.GetHashCode() == b2.GetHashCode());
```

The implementations of `ValueType.GetHashCode()` in MS.NET and Mono are different.

The declaration of `ValueType.GetHashCode()` in .NET Framework 4.5.1 in [referencesource.microsoft.com/#mscorlib/system/valuetype.cs](http://referencesource.microsoft.com/#mscorlib/system/valuetype.cs):

```cs
/*=================================GetHashCode==================================
**Action: Our algorithm for returning the hashcode is a little bit complex.  We look
**        for the first non-static field and get it's hashcode.  If the type has no
**        non-static fields, we return the hashcode of the type.  We can't take the
**        hashcode of a static member because if that member is of the same type as
**        the original type, we'll end up in an infinite loop.
**Returns: The hashcode for the type.
**Arguments: None.
**Exceptions: None.
==============================================================================*/
[System.Security.SecuritySafeCritical]  // auto-generated
[ResourceExposure(ResourceScope.None)]
[MethodImplAttribute(MethodImplOptions.InternalCall)]
public extern override int GetHashCode();
```

The [implementation](http://www.123aspx.com/rotor/RotorSrc.aspx?rot=42363) of `ValueType.GetHashCode()` in Rotor:

```cs
public override int GetHashCode() {
    // Note that for correctness, we can't use any field of the value type
    // since that field may be mutable in some way.  If we use that field
    // and the value changes, we may not be able to look up that type in a
    // hash table.  For correctness, we need to use something unique to
    // the type of this object.

    // HOWEVER, we decided that the perf of returning a constant value (such as
    // the hash code for the type) would be too big of a perf hit.  We're willing
    // to deal with less than perfect results, and people should still be
    // encouraged to override GetHashCode.

    BCLDebug.Correctness(!(this is System.Collections.DictionaryEntry), "Calling GetHashCode on DictionaryEntry is dumb and probably wrong.");
    BCLDebug.Perf(false, "ValueType::GetHashCode is not fast.  Perhaps "+this.GetType().FullName+" should override GetHashCode()");

    RuntimeType thisType = (RuntimeType)this.GetType();
    FieldInfo[] thisFields = thisType.InternalGetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, false);
    if (thisFields.Length>0) {
        for (int i=0; i<thisFields.Length; i++) {
            Object obj = ((Object)(((RuntimeFieldInfo)thisFields[i]).InternalGetValue((Object)this,false)));
            if (obj != null)
                return obj.GetHashCode();
        }
    }
    // Using the method table pointer is about 4x faster than getting the
    // sync block index for the Type object.
    return GetMethodTablePtrAsInt(this);
}
```

The [implementation](https://github.com/mono/mono/blob/mono-3.10.0/mono/metadata/icall.c) of `ValueType.GetHashCode()` in Mono 3.10.0:

```cs
ves_icall_System_ValueType_InternalGetHashCode (MonoObject *this, MonoArray **fields)
{
  MonoClass *klass;
  MonoObject **values = NULL;
  MonoObject *o;
  int count = 0;
  gint32 result = (int)(gsize)mono_defaults.int32_class;
  MonoClassField* field;
  gpointer iter;

  MONO_ARCH_SAVE_REGS;

  klass = mono_object_class (this);

  if (mono_class_num_fields (klass) == 0)
    return result;

  /*
   * Compute the starting value of the hashcode for fields of primitive
   * types, and return the remaining fields in an array to the managed side.
   * This way, we can avoid costly reflection operations in managed code.
   */
  iter = NULL;
  while ((field = mono_class_get_fields (klass, &iter))) {
    if (field->type->attrs & FIELD_ATTRIBUTE_STATIC)
      continue;
    if (mono_field_is_deleted (field))
      continue;
    /* FIXME: Add more types */
    switch (field->type->type) {
    case MONO_TYPE_I4:
      result ^= *(gint32*)((guint8*)this + field->offset);
      break;
    case MONO_TYPE_STRING: {
      MonoString *s;
      s = *(MonoString**)((guint8*)this + field->offset);
      if (s != NULL)
        result ^= mono_string_hash (s);
      break;
    }
    default:
      if (!values)
        values = g_newa (MonoObject*, mono_class_num_fields (klass));
      o = mono_field_get_value_object (mono_object_domain (this), field, this);
      values [count++] = o;
    }
  }

  if (values) {
    int i;
    mono_gc_wbarrier_generic_store (fields, (MonoObject*) mono_array_new (mono_domain_get (), mono_defaults.object_class, count));
    for (i = 0; i < count; ++i)
      mono_array_setref (*fields, i, values [i]);
  } else {
    *fields = NULL;
  }
  return result;
}
```

## Runs

* **ms** (Windows, MS.NET): `False True`
* **mono** (Linux, Mono 3.10): `False False`

## Links

* [MSDN: ValueType.GetHashCode Method](http://msdn.microsoft.com/library/system.valuetype.gethashcode.aspx)
* [StackOverflow: How does native implementation of ValueType.GetHashCode work?](http://stackoverflow.com/questions/5926776/how-does-native-implementation-of-valuetype-gethashcode-work)
* [Habrahabr article (In Russian)](http://habrahabr.ru/post/188038/)