namespace Third
{
    internal class Program
    {
        delegate int Operation(int x, int y, int z);

        static void Main(string[] args)
        {
            Operation average = delegate (int x, int y, int z)
            {
                return (x + y + z) / 3;
            };

            Console.WriteLine("Enter value for x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Average: " + average(x, y, z));

            Console.ReadLine();
        }

    }
}