namespace Second
{
    delegate int Delegate();

    class Program
    {
        static void Main(string[] args)
        {
            Delegate[] delegates = new Delegate[10];

            for (int i = 0; i < 10; i++)
            {
                delegates[i] = delegate
                {
                    Random rnd = new Random();
                    return rnd.Next(1, 100);
                };
            }

            Func<Delegate[], double> average = delegate (Delegate[] arr)
            {
                double sum = 0;
                foreach (Delegate del in arr)
                {
                    sum += del();
                }
                return sum / arr.Length;
            };

            Console.WriteLine("The average value is: " + average(delegates));

            Console.ReadLine();
        }
    }
}