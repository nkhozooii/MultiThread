namespace threading

{
    public class Test

    {
        private static Mutex mutex = new Mutex();


        public void Calculate()

        {

            try

            {
                mutex.WaitOne();   // Wait until it is safe to enter.

                Console.WriteLine("{0} has entered in the Domain",

                Thread.CurrentThread.Name);

                for (int i = 0; i < 10; i++)

                {

                    Thread.Sleep(new Random().Next(5));

                    Console.Write(" {0},", i);

                }
                Console.WriteLine();
                Console.WriteLine("{0} is leaving the Domain\r\n",

                    Thread.CurrentThread.Name);
            }

            catch { }

            finally

            {
                mutex.ReleaseMutex();
            }

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