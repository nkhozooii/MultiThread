var thread1 = new Thread(Thread1Job);
var thread2 = new Thread(Thread2Job);
var thread3 = new Thread(Thread3Job);
thread1.Start();
thread2.Start();
thread3.Start();
static void Thread1Job()
{
    for (int counter = 0; counter < 50; counter++)
    {
        Console.WriteLine("From thread1: " + counter);
    }
}

static void Thread2Job()
{
    for (int counter = 0; counter < 50; counter++)
    {
        Console.WriteLine("From thread2: " + counter);
    }
}

static void Thread3Job()
{
    for (int counter = 0; counter < 50; counter++)
    {
        Console.WriteLine("From thread3: " + counter);
    }
}