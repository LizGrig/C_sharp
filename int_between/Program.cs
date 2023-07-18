//Принимает целое число а, выдаёт все целые между -а и а.

Console.Write("Insert number: ");
int Number = int.Parse(Console.ReadLine());
int count = 0 - Number;

while(count <= Number)
{
    Console.Write($"{count} ");
    count++;
}