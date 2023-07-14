/*
Ввод числа и вывод его квадрата.
В C# можно вводить только строки, поэтому для ввода чисел используется конвертация.

Вариантов несколько:
1. int <name> = 0;
   int.TryParse(Console.ReadLine(), out <name>>);

2. <name> = int.Parse(Console.ReadLine());

3. <name> = Convert.ToInt32(Console.ReadLine());
*/

Console.Write("Введите число: ");
int a = 0;
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine(a);

int power = 2; // power of a
int result = (int)Math.Pow(a,power);
/*
Метод Math работает с типом double. Чтобы не менять тип, его нужно конвертировать.
Либо через Convert.ToInt32(Math.<..>), либо через (int).
*/
Console. WriteLine($"Square of {a} is {result}");
