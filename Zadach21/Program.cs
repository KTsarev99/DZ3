// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит врасстояние между ними в 3D пространсте.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите X координаты 1й точки");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y координаты 1й точки");
int A2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Z координаты 1й точки");
int A3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите X координаты 2й точки");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y координаты 2й точки");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Z координаты 1й точки");
int B3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"координаты A({A1},{A2},{A3})");
Console.WriteLine($"координаты B({B1},{B2},{B3})");

int x = A1 -B1;
int y = A2 -B2;
int z = A3 -B3;

double distance = Math.Sqrt ((x*x) + (y*y)+(z*z));
Console.WriteLine($"длинна между точками = {distance}");