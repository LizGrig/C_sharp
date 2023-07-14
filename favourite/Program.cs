Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hello, sweetheart!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}