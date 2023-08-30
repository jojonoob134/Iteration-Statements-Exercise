namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void OneEx()
        {
            for (int x = 1; x <= 1001; x++)
            {
                Console.WriteLine(x);
            }

            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            for (int y = 3; y <= 999; y += 3)
            {
                Console.WriteLine(y);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void OneEx5()
        {
            Console.WriteLine("pick a number");
            int evenOdds = int.Parse(Console.ReadLine());
            int resp = evenOdds % 2;
            if (resp == 0)
            {
                Console.WriteLine("this is even");
            }
            else
            {
                Console.WriteLine("this is odd");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void OneEx1()
        {
            Console.WriteLine("pick a number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("both are the same");
            }
            else
            {
                Console.WriteLine("both are different");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void OneEx2()
        {
            Console.WriteLine("pick a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("this is positive");
            }
            else
            {
                Console.WriteLine("this is negitive");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void OneEx6()
        {
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 30)
            {
                Console.WriteLine("you can be a candidate");
            }
            else
            {
                Console.WriteLine("you can not be a candidate");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void OneEx3()
        {
            Console.WriteLine("pick a number");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 <= 10 && num2 >= -10)
            {
                Console.WriteLine("this is in range");
            }
            else
            {
                Console.WriteLine("this is not in range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void OneEx4()
        {
            Console.WriteLine("pick a number");
            int bug = int.Parse(Console.ReadLine());
            Console.WriteLine($"multiplication of {bug} are {bug}, {bug * 2}, {bug * 3}, {bug * 4}, {bug * 5}, {bug * 6}, {bug * 7}, {bug * 8}, {bug * 9}, {bug * 10}, {bug * 11}, {bug * 12},");
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            OneEx();
            OneEx2();
            OneEx3();
            OneEx4();
            OneEx5();
            OneEx6();
        }
    }
}
