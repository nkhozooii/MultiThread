using System.Diagnostics.Metrics;

namespace threading

{
    public class Test

    {
        static Semaphore obj = new Semaphore(2, 4);


        public void Calculate()

        {
            Console.WriteLine("{0}-- >> Wants to Get Enter" , Thread.CurrentThread.Name);

            try

            {
                obj.WaitOne();   // Wait until it is safe to enter.

                Console.WriteLine(" Success: " + Thread.CurrentThread.Name + " is in!");

                Thread.Sleep(2000);

                Console.WriteLine(Thread.CurrentThread.Name + "<<-- is Evacuating");
            }

            catch { }

            finally

            {
                obj.Release();
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

                tr[i].Name = String.Format("{0}", i);

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