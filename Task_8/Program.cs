// Задача 8: Напишите программу, которая на вход принимает число (N), 
//           а на выходе показывает все чётные числа от 1 до N. 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("***************************************");
Console.WriteLine("Выведем все четные числа от 1 до N");
Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Исключаем ввод отрицательных чисел
int count = 2;

if (N < 2) //Проверяем условие для вывода цифр, так как условие актуально только для значения >= 2
{
    Console.WriteLine("Введите другое число");
}
else
{
    Console.Write("*");

    while (N >= count)
    {
        Console.Write(count);
        Console.Write(", ");
        count = count + 2;
    }
        Console.WriteLine("*");
}

Console.WriteLine("***************************************");