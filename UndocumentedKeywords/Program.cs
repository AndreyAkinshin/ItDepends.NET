using System;

public class Program
{
    public class OneLong
    {
        public long X;
    }
    public class TwoInt
    {
        public int Y1;
        public int Y2;
    }
    public static unsafe IntPtr GetAddress(object obj)
    {
        var typedReference = __makeref(obj);
        return *(IntPtr*)(&typedReference);
    }
    public static unsafe T Convert<T>(IntPtr address)
    {
        var fakeInstance = default(T);
        var typedReference = __makeref(fakeInstance);
        *(IntPtr*)(&typedReference) = address;
        return __refvalue( typedReference,T);
    }
    public static void Main()
    {
        var myObject = new OneLong { X = 1 + (2L << 32) };
        var pumpkin = Convert<TwoInt>(GetAddress(myObject));
        Console.WriteLine(pumpkin.Y1 + " " + pumpkin.Y2); // 1 2
        myObject.X = 3 + (4L << 32);
        Console.WriteLine(pumpkin.Y1 + " " + pumpkin.Y2); // 3 4
    }
}