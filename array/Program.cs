/*
При поиске максимального значения среди девяти чисел мож-
но использовать разные методы. Можно поочерёдно сравнить 
всё с наибольшим, а можно написать функцию, которая будет
искать наибольшее из трёх, и применить её четырежды.

int a1 = 1;   max = a1;
int b1 = 3;   if(b1 > max) max = b1;
int c1 = 2;   if(c1 > max) max = c1;
int a2 = 5;   if(a2 > max) max = a2;
int b2 = 2;   if(b2 > max) max = b2;
int c2 = 8;   if(c2 > max) max = c2;
int a3 = 4;   if(a3 > max) max = a3;
int b3 = 2;   if(b3 > max) max = b3;
int c3 = 3;   if(c3 > max) max = c3;

Функция:
int Max (int arg1, int arg2, int arg1)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;    
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max (max1, max2, max3);

То же самое, но короче:
int max = Max( 
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Но лучше всего массивы.
*/
//                0   1   2   3   4   5   6   7   8
//int[] array = {11, 21, 31, 41, 51, 61, 17, 18, 19};

// void - метод, не возвращающий значений, return не нужен

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{coll[position]} ");
        position++;
    }
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);

//Поиск индекса искомого значения

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.WriteLine();

int pos = IndexOf(arr, 4);
Console.WriteLine(pos);
