using System;

namespace MetanitLesson1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the operation number: 1. Addition 2. Subtraction 3. Multiplication: ");
            int operation = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number: ");
            int firstnum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondnum = int.Parse(Console.ReadLine());
            int result = 0;
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition");
                    result = firstnum + secondnum;
                    break;
                case 2:
                    Console.WriteLine("Subtraction");
                    result = firstnum - secondnum;
                    break;
                case 3:
                    Console.WriteLine("Multiplication");
                    result = firstnum * secondnum;
                    break;
                default:
                    Console.WriteLine("Operation is undefined");
                    break;
            }
            Console.WriteLine($"Result = {result}");
            Console.ReadLine();
        }
    }
}
