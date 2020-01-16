
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3752.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Calculator
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Calculator.exe
// MVID: {060DE347-ED9A-45A5-BDDF-C4DA87DFF486}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x073E0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit HelloWorldApp.Calculator
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       302 (0x12e)
    .maxstack  4
    .locals init (int32 V_0,
             int32 V_1,
             object[] V_2)
    IL_0000:  nop
    IL_0001:  ldstr      "Enter number:"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0011:  call       int32 [mscorlib]System.Convert::ToInt32(string)
    IL_0016:  stloc.0
    IL_0017:  ldstr      "Enter number:"
    IL_001c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0021:  nop
    IL_0022:  call       string [mscorlib]System.Console::ReadLine()
    IL_0027:  call       int32 [mscorlib]System.Convert::ToInt32(string)
    IL_002c:  stloc.1
    IL_002d:  ldc.i4.5
    IL_002e:  newarr     [mscorlib]System.Object
    IL_0033:  stloc.2
    IL_0034:  ldloc.2
    IL_0035:  ldc.i4.0
    IL_0036:  ldloc.0
    IL_0037:  box        [mscorlib]System.Int32
    IL_003c:  stelem.ref
    IL_003d:  ldloc.2
    IL_003e:  ldc.i4.1
    IL_003f:  ldstr      "+"
    IL_0044:  stelem.ref
    IL_0045:  ldloc.2
    IL_0046:  ldc.i4.2
    IL_0047:  ldloc.1
    IL_0048:  box        [mscorlib]System.Int32
    IL_004d:  stelem.ref
    IL_004e:  ldloc.2
    IL_004f:  ldc.i4.3
    IL_0050:  ldstr      "="
    IL_0055:  stelem.ref
    IL_0056:  ldloc.2
    IL_0057:  ldc.i4.4
    IL_0058:  ldloc.0
    IL_0059:  ldloc.1
    IL_005a:  add
    IL_005b:  box        [mscorlib]System.Int32
    IL_0060:  stelem.ref
    IL_0061:  ldloc.2
    IL_0062:  call       string [mscorlib]System.String::Concat(object[])
    IL_0067:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_006c:  nop
    IL_006d:  ldc.i4.5
    IL_006e:  newarr     [mscorlib]System.Object
    IL_0073:  stloc.2
    IL_0074:  ldloc.2
    IL_0075:  ldc.i4.0
    IL_0076:  ldloc.0
    IL_0077:  box        [mscorlib]System.Int32
    IL_007c:  stelem.ref
    IL_007d:  ldloc.2
    IL_007e:  ldc.i4.1
    IL_007f:  ldstr      "-"
    IL_0084:  stelem.ref
    IL_0085:  ldloc.2
    IL_0086:  ldc.i4.2
    IL_0087:  ldloc.1
    IL_0088:  box        [mscorlib]System.Int32
    IL_008d:  stelem.ref
    IL_008e:  ldloc.2
    IL_008f:  ldc.i4.3
    IL_0090:  ldstr      "="
    IL_0095:  stelem.ref
    IL_0096:  ldloc.2
    IL_0097:  ldc.i4.4
    IL_0098:  ldloc.0
    IL_0099:  ldloc.1
    IL_009a:  sub
    IL_009b:  box        [mscorlib]System.Int32
    IL_00a0:  stelem.ref
    IL_00a1:  ldloc.2
    IL_00a2:  call       string [mscorlib]System.String::Concat(object[])
    IL_00a7:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00ac:  nop
    IL_00ad:  ldc.i4.5
    IL_00ae:  newarr     [mscorlib]System.Object
    IL_00b3:  stloc.2
    IL_00b4:  ldloc.2
    IL_00b5:  ldc.i4.0
    IL_00b6:  ldloc.0
    IL_00b7:  box        [mscorlib]System.Int32
    IL_00bc:  stelem.ref
    IL_00bd:  ldloc.2
    IL_00be:  ldc.i4.1
    IL_00bf:  ldstr      "*"
    IL_00c4:  stelem.ref
    IL_00c5:  ldloc.2
    IL_00c6:  ldc.i4.2
    IL_00c7:  ldloc.1
    IL_00c8:  box        [mscorlib]System.Int32
    IL_00cd:  stelem.ref
    IL_00ce:  ldloc.2
    IL_00cf:  ldc.i4.3
    IL_00d0:  ldstr      "="
    IL_00d5:  stelem.ref
    IL_00d6:  ldloc.2
    IL_00d7:  ldc.i4.4
    IL_00d8:  ldloc.0
    IL_00d9:  ldloc.1
    IL_00da:  mul
    IL_00db:  box        [mscorlib]System.Int32
    IL_00e0:  stelem.ref
    IL_00e1:  ldloc.2
    IL_00e2:  call       string [mscorlib]System.String::Concat(object[])
    IL_00e7:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00ec:  nop
    IL_00ed:  ldc.i4.5
    IL_00ee:  newarr     [mscorlib]System.Object
    IL_00f3:  stloc.2
    IL_00f4:  ldloc.2
    IL_00f5:  ldc.i4.0
    IL_00f6:  ldloc.0
    IL_00f7:  box        [mscorlib]System.Int32
    IL_00fc:  stelem.ref
    IL_00fd:  ldloc.2
    IL_00fe:  ldc.i4.1
    IL_00ff:  ldstr      "/"
    IL_0104:  stelem.ref
    IL_0105:  ldloc.2
    IL_0106:  ldc.i4.2
    IL_0107:  ldloc.1
    IL_0108:  box        [mscorlib]System.Int32
    IL_010d:  stelem.ref
    IL_010e:  ldloc.2
    IL_010f:  ldc.i4.3
    IL_0110:  ldstr      "="
    IL_0115:  stelem.ref
    IL_0116:  ldloc.2
    IL_0117:  ldc.i4.4
    IL_0118:  ldloc.0
    IL_0119:  ldloc.1
    IL_011a:  div
    IL_011b:  box        [mscorlib]System.Int32
    IL_0120:  stelem.ref
    IL_0121:  ldloc.2
    IL_0122:  call       string [mscorlib]System.String::Concat(object[])
    IL_0127:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_012c:  nop
    IL_012d:  ret
  } // end of method Calculator::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Calculator::.ctor

} // end of class HelloWorldApp.Calculator


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\pc\Desktop\dotnet\jbdot.res
