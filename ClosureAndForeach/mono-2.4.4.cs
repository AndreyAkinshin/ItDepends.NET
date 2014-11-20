// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Program, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 85F7BCE8-5446-4711-A9D7-FF656290A123
// Compiler-generated code is shown

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Program
{
  public Program()
  {
    base.\u002Ector();
  }

  public static void Main()
  {
    int[] numArray1 = new int[3];
    int index1 = 0;
    int num1 = 1;
    numArray1[index1] = num1;
    int index2 = 1;
    int num2 = 2;
    numArray1[index2] = num2;
    int index3 = 2;
    int num3 = 3;
    numArray1[index3] = num3;
    int[] numArray2 = numArray1;
    List<Action> list = new List<Action>();
    Program.\u003CMain\u003Ec__AnonStorey0 mainCAnonStorey0 = new Program.\u003CMain\u003Ec__AnonStorey0();
    foreach (int num4 in numArray2)
    {
      mainCAnonStorey0.number = num4;
      // ISSUE: method pointer
      list.Add(new Action((object) mainCAnonStorey0, __methodptr(\u003C\u003Em__0)));
    }
    using (List<Action>.Enumerator enumerator = list.GetEnumerator())
    {
      while (enumerator.MoveNext())
        enumerator.Current();
    }
  }

  [CompilerGenerated]
  private sealed class \u003CMain\u003Ec__AnonStorey0
  {
    internal int number;

    public \u003CMain\u003Ec__AnonStorey0()
    {
      base.\u002Ector();
    }

    internal void \u003C\u003Em__0()
    {
      Console.WriteLine(this.number);
    }
  }
}