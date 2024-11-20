using System;

Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter operation (-, +, *, /): ");
char operation = Console.ReadKey().KeyChar;
double result;
Console.WriteLine();
Console.Write("Result: ");

switch (operation)
{
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case '/':
        try
        {
            result = firstNumber / secondNumber;
            Console.WriteLine(firstNumber / secondNumber);
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

