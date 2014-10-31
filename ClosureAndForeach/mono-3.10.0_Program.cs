// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Program, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 75B6A678-E654-41E4-84B3-D34AA9E98301
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
    int[] numArray = new int[3]
    {
      1,
      2,
      3
    };
    List<Action> list = new List<Action>();
    foreach (int num in numArray)
    {
      Program.\u003CMain\u003Ec__AnonStorey0 mainCAnonStorey0 = new Program.\u003CMain\u003Ec__AnonStorey0();
      mainCAnonStorey0.number = num;
      // ISSUE: method pointer
      list.Add(new Action((object) mainCAnonStorey0, __methodptr(\u003C\u003Em__0)));
    }
    foreach (Action action in list)
      action();
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