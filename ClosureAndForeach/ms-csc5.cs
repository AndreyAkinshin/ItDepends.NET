// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Program, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 729FD3A8-0EC7-414C-A0C0-1C5EBA1F70CA
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
      Program.\u003C\u003Ec__DisplayClass1 cDisplayClass1 = new Program.\u003C\u003Ec__DisplayClass1();
      cDisplayClass1.number = num;
      // ISSUE: method pointer
      list.Add(new Action((object) cDisplayClass1, __methodptr(\u003CMain\u003Eb__0)));
    }
    foreach (Action action in list)
      action();
  }

  [CompilerGenerated]
  private sealed class \u003C\u003Ec__DisplayClass1
  {
    public int number;

    public \u003C\u003Ec__DisplayClass1()
    {
      base.\u002Ector();
    }

    public void \u003CMain\u003Eb__0()
    {
      Console.WriteLine(this.number);
    }
  }
}