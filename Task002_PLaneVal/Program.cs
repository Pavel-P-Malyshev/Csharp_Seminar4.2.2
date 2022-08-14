/*

Задача 2: Напишите программу, которая по 
заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).


*/




int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


void PlaneNum(int quadrant)
{
    if(quadrant==1) 
    {
        Console.WriteLine("in this quadrant X range and Y range are both positive values!");
        
    }

    if(quadrant==2)
    {
        
      Console.WriteLine("in this quadrant X values range is negative  and Y values range is positive!");
    }


    if(quadrant==3) 
    {
        Console.WriteLine("in this quadrant X values range is negative  and Y values is negative!");
    }
    
    if(quadrant==4) 
    {
        Console.WriteLine("in this quadrant X values range is positive and Y values range is negative!");

    }

    
    

}


int q=0;

q=Prompt("enter quadrant number:");
while(q<1||q>4)
{
    q=Prompt("Quadrant range is 1-4, enter correct quadrant number:");
}
PlaneNum(q);
