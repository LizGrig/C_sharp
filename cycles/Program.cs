/*
Методы или функции делятся на возвращающие результат и не возвращающие.
Те, в свою очередь, делятся на принимающие на вход данные и не принимающие.

void Meth1()
{
    Console.WriteLine("<text>");
}

void Meth2(string msg)
{
    Console.WriteLine(msg);
}
Meth2("<text>");

void Meth21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Meth21(count: 4, msg: "<text>");

int Meth3()
{
    return DateTime.Now.Year;
}
int year = Meth3();

string Meth4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result
}
string res = Meth4(10,"<text>");

*/

/*
string Meth4(int count, string c)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + c;        
    }
    return result;
}
string res = Meth4(10,"<text>");
Console.WriteLine(res);
*/

/*
for(int i = 2; i<=10; i++)
{
    for(int j = 2; j<=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Дан текст.
// " " => "_".
// "к" => "К".
// "с" => "С".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012345
//s[3] - r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();

string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();

string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);
Console.WriteLine();