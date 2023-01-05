namespace ConsoleCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What you want to do (sum, multiply, substract or divide)? ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "sum":
                    Console.WriteLine($"{a} + {b} = " + (a + b));
                    break;
                case "multiply":
                    Console.WriteLine($"{a} * {b} = " + (a * b));
                    break;
                case "substract":
                    Console.WriteLine($"{a} - {b} = " + (a - b));
                    break;
                case "divide":
                    Console.WriteLine($"{a} % {b} = " + (a % b));
                    break;
                default:
                    Console.WriteLine("That's a weong choice. Please, try again.");
                    break;
            }
        }
    }
}