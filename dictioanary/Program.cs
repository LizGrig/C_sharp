/*
2. Вывод название дня недели по введённому номеру.
*/

Console.Write ("Insert number: ");
int NumberOfDay = Convert.ToInt32(Console.ReadLine());

Dictionary <int,string> map = new Dictionary<int, string>()
{
    {1, "Mon"},
    {2, "Tue"},
    {3, "Wed"},
    {4, "Thur"},
    {5, "Fri"},
    {6, "Sat"},
    {7, "Sun"}
};

if (NumberOfDay > 0 && NumberOfDay < 8)
{
    Console.WriteLine(map[NumberOfDay]);
}
else
{
    Console.WriteLine("Wrong number");
}