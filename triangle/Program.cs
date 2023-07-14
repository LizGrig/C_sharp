Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1, ya = 1, 
    xb = 1, yb = 20, 
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = 0, y = 0;

int dot = new Random().Next(0,3);
if(dot == 0)
{
    x = (xa+xb)/2;
    y = (ya+yb)/2;    
}
else
{
    if(dot == 1)
    {
        x = (xa+xc)/2;
        y = (ya+yc)/2;
    }
    else
    {
        x = (xb+xc)/2;
        y = (yb+yc)/2;
    }
}

Console.SetCursorPosition(x,y);
Console.WriteLine("+");

int count = 0;

while(count<1000)
{
    int what = new Random().Next(1,4);
    if(what == 1)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
   
    if(what == 2)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(what == 3)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count = count + 1;
}