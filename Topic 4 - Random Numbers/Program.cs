namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // #1 Random Integers
            Random generator = new Random();

            //int min, max;
            //Console.WriteLine("Enter a minimum and maximum number.");
            //Console.WriteLine();
            //Console.WriteLine("Minimum: ");
            //min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Maximum: ");
            //max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine() ;
            //Console.WriteLine("Here are five random numbers.");
            //Console.WriteLine();
            //Console.WriteLine(generator.Next(min, max));
            //Console.WriteLine();
            //Console.WriteLine(generator.Next(min, max));
            //Console.WriteLine();
            //Console.WriteLine(generator.Next(min, max));
            //Console.WriteLine();
            //Console.WriteLine(generator.Next(min, max));
            //Console.WriteLine();
            //Console.WriteLine(generator.Next(min, max));
            //Console.WriteLine();

            // #2 Dice Roller

            //int num1, num2, total;
            //Console.WriteLine("Press ENTER to roll both dice.");
            //Console.ReadLine();
            //num1 = generator.Next(1, 7);
            //num2 = generator.Next(1, 7);
            //total = num1 + num2;
            //Console.WriteLine("First Dice - " + num1);
            //Console.ReadLine();
            //Console.WriteLine("Second Dice - " + num2);
            //Console.ReadLine();
            //Console.WriteLine("Total - " + total);

            // #3 Random Decimal Numbers
            int min, max;
            double min1, max1;
            Console.WriteLine("Enter a minimum and maximum number.");
            Console.WriteLine();
            Console.WriteLine("Minimum: ");
            min = Convert.ToInt32(Console.ReadLine());
            min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Maximum: ");
            max = Convert.ToInt32(Console.ReadLine());
            max1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Here are five random numbers.");
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max) + generator.NextDouble(min1,max1));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max) + generator.NextDouble(min1,max1));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max) + generator.NextDouble(min1, max1));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max) + generator.NextDouble(min1, max1));
            Console.WriteLine();
            Console.WriteLine(generator.Next(min, max) + generator.NextDouble(min1, max1));
            Console.WriteLine();
        }
    }
}
