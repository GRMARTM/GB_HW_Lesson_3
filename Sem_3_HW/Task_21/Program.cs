// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки 1: ");

string[] sArr = Console.ReadLine().Split(' ');
int num1 = Convert.ToInt32(sArr[0]);
int num2 = Convert.ToInt32(sArr[1]);
int num3 = Convert.ToInt32(sArr[2]);

Console.WriteLine("Введите координаты точки 2: ");

string[] sArr2 = Console.ReadLine().Split(' ');
int num4 = Convert.ToInt32(sArr2[0]);
int num5 = Convert.ToInt32(sArr2[1]);
int num6 = Convert.ToInt32(sArr2[2]);


double result = Math.Round(Math.Sqrt(Math.Pow((num4 - num1), 2)+ Math.Pow((num5 - num2),2)  + Math.Pow((num6 - num3),2)), 2);
Console.Write(result);
