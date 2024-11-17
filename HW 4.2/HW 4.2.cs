using System;

Console.Write("Enter first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double secondNumber = double.Parse(Console.ReadLine());
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
        if (secondNumber == 0) // Виключення ділення на нуль
            Console.WriteLine("Error: division by zero");
        else
            Console.WriteLine(firstNumber / secondNumber);
        break;
    default:
        Console.WriteLine("Error: unknown input");
        break;
}

