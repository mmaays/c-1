namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("\nChoose an operation :");
                Console.WriteLine("a- Add");
                Console.WriteLine("b- Subtract");
                Console.WriteLine("c- Multiply");
                Console.WriteLine("d- Divide");
                Console.WriteLine("e- Exit");
                Console.Write("your choice : ");

                string choice = Console.ReadLine().ToLower();

                if (choice == "e")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }

                switch (choice)
                {
                    case "a": Add(); break;

                    case "b": Subtract(); break;

                    case "c": Multiply(); break;

                    case "d": Divide(); break;

                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
            }
        }

        static void Add()
        {
            double x = ReadNumber("Enter first number: ");
            double y = ReadNumber("Enter second number: ");
            Console.WriteLine($"Result: {x + y}");
        }

        static void Subtract()
        {
            double x = ReadNumber("Enter first number: ");
            double y = ReadNumber("Enter second number: ");
            Console.WriteLine($"Result: {x - y}");
        }

        static void Multiply()
        {
            double x = ReadNumber("Enter first number: ");
            double y = ReadNumber("Enter second number: ");
            Console.WriteLine($"Result: {x * y}");
        }

        static void Divide()
        {
            double x = ReadNumber("Enter first number: ");
            double y;
            do
            {
                y = ReadNumber("Enter second number (!= 0): ");
                if (y == 0)
                    Console.WriteLine("Cannot divide by zero.");
            } while (y == 0);

            Console.WriteLine($"Result: {x / y}");
        }

        static double ReadNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                Console.WriteLine("Invalid input. Try again.");
            }
        }

    }
}
