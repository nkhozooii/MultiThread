namespace threading

{
   // [Synchronization] ?????????????????
    public class Test //: ContextBoundObject???????????

    {
        public void Calculate()

        {
           
                Console.Write(" {0} is Executing", Thread.CurrentThread.Name);

                for (int i = 0; i < 10; i++)

                {

                    Thread.Sleep(new Random().Next(5));

                    Console.Write(" {0},", i);

                }

                Console.WriteLine();

       
        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Test t = new Test();

            Thread[] tr = new Thread[5];



            for (int i = 0; i < 5; i++)

            {

                tr[i] = new Thread(new ThreadStart(t.Calculate));

                tr[i].Name = String.Format("Working Thread: {0}", i);

            }



            //Start each thread

            foreach (Thread x in tr)

            {

                x.Start();

            }

            Console.ReadKey();

        }

    }

}