namespace AdjacentMaxDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjacent Max Distance: " + Calculator.FindAdjacentMaxDistance(new int[] { 0, 3, 3, 7, 5, 3, 11, 1 }));
            Console.WriteLine("Adjacent Max Distance: " + Calculator.FindAdjacentMaxDistance(new int[] { 0, 3, 3, 12, 5, 3, 7, 1 }));
            Console.ReadLine();

            // Easier way
            // List<int> ListOfNumbers = new(args.Select(item => (Convert.ToInt32(item))));

            int[] arrayOfNumbers = new int[args.Length];

            for (int index = 0; index < args.Length; index++)
            {
                string item = args[index];

                try
                {
                    int intNumber = Convert.ToInt32(item);
                    arrayOfNumbers[index] = intNumber;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} is outside the range of the Int32 type.", item);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                      item.GetType().Name, item);
                }
            }

            // Console.WriteLine("Adjacent Max Distance: " + Calculator.FindAdjacentMaxDistance(arrayOfNumbers));

            Console.ReadLine();
        }
    }
}
