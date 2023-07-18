/*
1. Ввод 2х чисел и проверка, является ли первое квадратом второго.
*/

Console.Write("Insert first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number: ");
int b = Convert.ToInt32(Console.ReadLine());

bool square = false;

if (a == b*b)
{
    square = true;
}

Console.WriteLine($"It's {square} that {a} is a square of {b}");