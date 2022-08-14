/*

Задача 3: Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21


*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


double dist2D(int[]A, int[] B)
{
       return Math.Sqrt(Math.Pow(A[0]-B[0],2)+Math.Pow(A[1]-B[1],2));    

}


int[] pointA=new int[2];
int[] pointB=new int[2];


pointA[0]=Prompt("enter x of point A:");
pointA[1]=Prompt("enter y of point A:");
pointB[0]=Prompt("enter x of point B:");
pointB[1]=Prompt("enter y of point B:");


Console.WriteLine($"Distance between point A and point B in 2D grid is:  {dist2D(pointA, pointB)}");
