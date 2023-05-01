namespace Second
{
    class Program
    {
        static Semaphore semaphore = new Semaphore(2, 2);
        static object lockObject = new object();
        static int currentGreenLight = 0;

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[4];

            for (int i = 0; i < threads.Length; i++)
            {
                int index = i;
                threads[i] = new Thread(() => TrafficLight(index));
                threads[i].Start();
            }

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Car);
                thread.Start();
            }
        }

        static void TrafficLight(int index)
        {
            while (true)
            {
                lock (lockObject)
                {
                    if (index == currentGreenLight)
                    {
                        Console.WriteLine($"Traffic light {index} is green");
                        currentGreenLight = (currentGreenLight + 1) % 4;
                        Monitor.PulseAll(lockObject);
                    }
                    else
                    {
                        Console.WriteLine($"Traffic light {index} is red");
                        Monitor.Wait(lockObject);
                    }
                }

                Thread.Sleep(3000);
            }
        }

        static void Car()
        {
            Console.WriteLine("Car approaching intersection");

            semaphore.WaitOne();
            Console.WriteLine("Car entered intersection");

            Thread.Sleep(2000);

            Console.WriteLine("Car left intersection");
            semaphore.Release();
        }
    }
}