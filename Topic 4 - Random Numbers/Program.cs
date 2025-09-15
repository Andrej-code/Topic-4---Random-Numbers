namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // #1 Random Integers
            Random generator = new Random();

            int min, max;
            Console.WriteLine("Enter a minimum and maximum number.");
            Console.WriteLine();
            Console.WriteLine("Minimum: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Maximum: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine() ;
            Console.WriteLine("Here are five random numbers.");
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max));
            Console.WriteLine();
        // #2 Dice Roller
            
        }
    }
}
