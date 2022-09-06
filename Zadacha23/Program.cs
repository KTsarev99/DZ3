//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
double n = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= n)
{
    double kub = 3;
    double sum = Math.Pow(index, kub);

    index++;
    Console.WriteLine(sum);
} 
