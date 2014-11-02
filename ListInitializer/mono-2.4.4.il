.assembly extern mscorlib
{
  .ver 1:0:5000:0
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 ) // .z\V.4..
}
.assembly 'Program'
{
  .hash algorithm 0x00008004
  .ver  0:0:0:0
}
.module Program.exe // GUID = {E05D198E-ED56-46ED-A11C-8E54A646A061}


  .class public auto ansi beforefieldinit Program
  	extends [mscorlib]System.Object
  {

    // method line 1
    .method public hidebysig  specialname  rtspecialname 
           instance default void '.ctor' ()  cil managed 
    {
        // Method begins at RVA 0x20ec
	// Code size 7 (0x7)
	.maxstack 8
	IL_0000:  ldarg.0 
	IL_0001:  call instance void object::'.ctor'()
	IL_0006:  ret 
    } // end of method Program::.ctor

    // method line 2
    .method public static  hidebysig 
           default void Main ()  cil managed 
    {
        // Method begins at RVA 0x20f4
	.entrypoint
	// Code size 20 (0x14)
	.maxstack 4
	.locals init (
		int32[]	V_0)
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
	IL_0013:  ret 
    } // end of method Program::Main

  } // end of class Program

