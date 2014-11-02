.assembly extern mscorlib
{
  .ver 2:0:0:0
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) // .z\V.4..
}
.assembly 'Program'
{
  .custom instance void class [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::'.ctor'() =  (
		01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
		63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01       ) // ceptionThrows.

  .hash algorithm 0x00008004
  .ver  0:0:0:0
}
.module Program.exe // GUID = {DE495E46-BF42-4605-A020-39DDDDFE413C}


  .class public auto ansi beforefieldinit Program
  	extends [mscorlib]System.Object
  {

    // method line 1
    .method public hidebysig specialname rtspecialname 
           instance default void '.ctor' ()  cil managed 
    {
        // Method begins at RVA 0x2050
	// Code size 7 (0x7)
	.maxstack 8
	IL_0000:  ldarg.0 
	IL_0001:  call instance void object::'.ctor'()
	IL_0006:  ret 
    } // end of method Program::.ctor

    // method line 2
    .method public static hidebysig 
           default void Main ()  cil managed 
    {
        // Method begins at RVA 0x2058
	.entrypoint
	// Code size 19 (0x13)
	.maxstack 3
	.locals init (
		int32[]	V_0)
	IL_0000:  ldc.i4.3 
	IL_0001:  newarr [mscorlib]System.Int32
	IL_0006:  dup 
	IL_0007:  ldtoken field valuetype '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'/'$ArrayType=12' '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'::'$field-0'
	IL_000c:  call void class [mscorlib]System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(class [mscorlib]System.Array, valuetype [mscorlib]System.RuntimeFieldHandle)
	IL_0011:  stloc.0 
	IL_0012:  ret 
    } // end of method Program::Main

  } // end of class Program

  .class private auto ansi abstract sealed beforefieldinit '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'
  	extends [mscorlib]System.Object
  {
    .custom instance void class [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::'.ctor'() =  (01 00 00 00 ) // ....

    .field  assembly static  valuetype '<PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}'/'$ArrayType=12' '$field-0' at D_00004000

  .class nested private explicit ansi sealed beforefieldinit '$ArrayType=12'
  	extends [mscorlib]System.ValueType
  {
    .pack 1
    .size 12

  } // end of class $ArrayType=12

  } // end of class <PrivateImplementationDetails>{de495e46-bf42-4605-a020-39ddddfe413c}

.data D_00004000 = bytearray (
	 01 00 00 00 02 00 00 00 03 00 00 00) // size: 12
