using System;

using System.Threading;



namespace threading

{

    class Program

    {

        static void Main(string[] args)

        {

            Thread t = new Thread(myFun);

            t.Name = "Thread1";

            //t.IsBackground = false;
            t.IsBackground=true;

            t.Start();

            Console.WriteLine("Main thread Running");

            Console.ReadKey();

        }



        static void myFun()

        {

            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);

        }

    }

}