using System;

internal class Program
{
    public delegate int MathOperation(int n1, int n2);
    //IAsyncResult BeginInvoke(int n1, int n2, AsyncCallBack callback, object state);
    //int EndInvoke(IAsyncResult result);
    private static void Main(string[] args)
    {
        //MathOperation operation = new MathOperation(Add);
        //Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);
        //operation(2, 6);
        MathOperation operation = new MathOperation(Add);
        Console.WriteLine("Main thread ID:" + Thread.CurrentThread.ManagedThreadId);
        var result = operation.BeginInvoke(2, 6, null, null);
        Console.WriteLine("Task in Main method.");
        var answer = operation.EndInvoke(result);
        Console.WriteLine("2 + 6 = {0}", answer);
    }
    public static int Add(int n1, int n2)
    {
        Console.WriteLine("Add thread ID: " + Thread.CurrentThread.ManagedThreadId);
        return n1 + n2;
    }
}