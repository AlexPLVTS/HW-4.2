using System;

try
{
Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter operation (-, +, *, /): ");
char operation = Console.ReadKey().KeyChar;
int result;
Console.WriteLine();
Console.Write("Result: ");

    switch (operation)
    {
        case '-':
            Console.WriteLine(firstNumber - secondNumber);
            break;
        case '+':
            Console.WriteLine(firstNumber + secondNumber);
            break;
        case '*':
            Console.WriteLine(firstNumber * secondNumber);
            break;
        case '/':
            try
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero");
            }
            break;
        default:
            Console.WriteLine("Error: unknown input");
            break;
    }
}
catch (FormatException)
{
    Console.WriteLine("Incorrect format");
}
