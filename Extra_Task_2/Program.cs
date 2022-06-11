// Задача 2. Даны два числа a, b, такие что a < b. 
// Вывести на экран сколько раз число a поместиться в числе b.

Console.Clear();
Console.WriteLine("***************************************");
Console.WriteLine("Сколько раз а поместиться в число b");

int a = new Random().Next(1, 1000);
int b = new Random().Next(1, 1000);

while (a > b)
{
// Console.WriteLine(a); Вводил для проверки работы подбора случаных чисел
// Console.WriteLine(b);
a = new Random().Next(1, 1000);
b = new Random().Next(1, 1000);
}

Console.Write("Случайное  число а = ");
Console.WriteLine(a);
Console.Write("Случайное  число b = ");
Console.WriteLine(b);

Console.Write("Число a поместится в b ");
Console.Write(b / a);
Console.WriteLine(" раз/a");
Console.WriteLine("***************************************");
