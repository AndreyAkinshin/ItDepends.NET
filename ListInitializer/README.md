## Description

The code:

```cs
var numbers = new int[] { 1, 2, 3 };
```

IL for mono 2.10:
```
IL_0000:  ldc.i4.3 
IL_0001:  newarr [mscorlib]System.Int32
IL_0006:  dup 
IL_0007:  ldtoken field valuetype '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'/'$ArrayType=12' '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'::'$field-0'
IL_000c:  call void class [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(class [mscorlib]System.Array, valuetype [mscorlib]System.RuntimeFieldHandle)
IL_0011:  stloc.0 
// ...
.field  assembly static  valuetype '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'/'$ArrayType=12' '$field-0' at D_00004000
// ...
.data D_00004000 = bytearray (
   01 00 00 00 02 00 00 00 03 00 00 00) // size: 12
```

IL for mono 2.4:
```
IL_0000:  ldc.i4.3 
IL_0001:  newarr [mscorlib]System.Int32
IL_0006:  dup 
IL_0007:  ldc.i4.0 
IL_0008:  ldc.i4.1 
IL_0009:  stelem.i4 
IL_000a:  dup 
IL_000b:  ldc.i4.1 
IL_000c:  ldc.i4.2 
IL_000d:  stelem.i4 
IL_000e:  dup 
IL_000f:  ldc.i4.2 
IL_0010:  ldc.i4.3 
IL_0011:  stelem.i4 
IL_0012:  stloc.0 
```