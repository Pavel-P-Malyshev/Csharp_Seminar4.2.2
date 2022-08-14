/*
1. Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой находится 
эта точка.
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


int PlaneNum(int x, int y)
{
    if(x>0&&y>0) 
    {
        Console.WriteLine("Your point belongs in 1st quadrant!");
        return 1;
    }

    if(x<0&&y>0)
    {
        Console.WriteLine("Your point belongs in 2nd quadrant!");
        return 2;
    } 
    
    if(x<0&&y<0) 
    {
        Console.WriteLine("Your point belongs in 3rd quadrant!");
        return 3;
    }
    
    if(x>0&&y<0) 
    {
        Console.WriteLine("Your point belongs in 4th quadrant!");
        return 4;
    }

    if (x==0||y==0) Console.WriteLine("Your point lays on the plane border");
    return 0;

}


int X=0;
int Y=0;
X=Prompt("enter x of your point:");
Y=Prompt("enter y of your point:");
PlaneNum(X,Y);