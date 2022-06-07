// Задача 2. Даны два числа a, b, такие что a < b. 
// Вывести на экран сколько раз число a поместиться в числе b.

Console.Clear();
Console.WriteLine("***************************************");
Console.WriteLine("Сколько раз а поместиться в число b");

Console.Write("Введите число a: "); //Запрашиваем первое число
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: "); //Запрашиваем второе число
int b = Convert.ToInt32(Console.ReadLine());

if (b < a) //Проверяем выполение условия задачи a < b
{
    Console.Write("Введеное b, меньше a, не соответствует условию задачи");
}
else
{
Console.Write("Число a поместится в b ");
Console.Write(b / a);
Console.WriteLine(" раз/a");
Console.WriteLine("***************************************");
}