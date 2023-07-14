// Принимает трёхзначное, выдаёт остаток от деления на 10.

Console.Write("Insert number: ");
int a = int.Parse(Console.ReadLine()), result = 0;

if (a > 99 && a <1000)
{
    result = a%10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("wrong number");
}
