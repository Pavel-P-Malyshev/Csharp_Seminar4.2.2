/*

Задача 4: Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4


*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


List<int> SquareList(int N)
{
    int index=1;

    List<int> result=new List<int>();
    while (index<=N)
    {
       result.Add((int)Math.Pow(index,2));
       index++;
    }

    return result;
   
}


int n=Prompt("enter integer 'N':  ");

while(n<1)  {n=Prompt("N cannot be less than 1, enter integer 'N':  ");}

List<int> answer=new List<int>();
answer=SquareList(n);

Console.Write("Square list of natural numbers between 1 and N is:  ");
for(int i=0;i<answer.Count;i++)
{
    if(i==answer.Count-1) Console.Write($"{answer[i]}.");
    else {Console.Write($"{answer[i]}, ");}
    
}

