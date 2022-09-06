Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());


if(number > 9999 && number < 100000 )
{
    int part1 = number% 10;
    int part2 = number/10000;
    int part3 = number% 100/10;
    int part4 = number/1000%10;
    if(part1 == part2 && part3 == part4)
    Console.WriteLine("да");
else
{
    Console.WriteLine("нет");
}
}
else
{
    Console.WriteLine("Введите пятизначное");
}