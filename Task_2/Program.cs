//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Определим MAX и MIN для двух чисел, для этого:");
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

//Можно заменить на int x = 5; int y = 7;

if (x > y) //Проверяем как число больше
{
    Console.Write("MAX = ");
    Console.WriteLine(x);
    Console.Write("MIN = ");
    Console.WriteLine(y);
}
else
{
    Console.Write("MAX = ");
    Console.WriteLine(y);
    Console.Write("MIN = ");
    Console.WriteLine(x);
}