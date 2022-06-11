// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран. 
// N = 4 -> 1, 1, 1, 1
// N = 2 -> 1, 1

Console.Clear();
Console.WriteLine("***************************************");
Console.WriteLine("Выводим количество единиц по числу N");
Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine())); //Исключаем ввод отрицательного числа
int numbers = 1;

if (N != 0)
{
    while (numbers < N)
    {
        Console.Write("1, ");
        numbers++;
    }
        
    if (numbers == N) // Добавил условие, чтобы убрать знак "," в конце строки
    {
        Console.Write("1");
    }

    Console.WriteLine("");
}
else
{
    Console.WriteLine("Введите число большее 0");
}
Console.WriteLine("***************************************");