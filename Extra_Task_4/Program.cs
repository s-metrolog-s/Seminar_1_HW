// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
// N = 72334 -> 20:5:34 

// int N = 72334;
int N = new Random().Next(1, 100000);
int hour;
int min;
int sec;

Console.Clear();
Console.WriteLine("***************************************");
Console.Write("Дано число секунд равное ");
Console.WriteLine(N);
Console.WriteLine("Представим число в виде чч:мм:сс");

hour = N / 3600; //Считаем целое киолчество часов
min = (N - (hour * 3600)) / 60; //Считаем целое киолчество минут
sec = (N - hour * 3600 - min * 60); //Оставшееся присваиваем секундам

if (hour < 10) //Добавляем 0, если получается значение из одного знака
{
    Console.Write(0);
    Console.Write(hour);
    Console.Write(":");
}
else
{
    Console.Write(hour);
    Console.Write(":");
}

if (min < 10) //Добавляем 0, если получается значение из одного знака
{
    Console.Write(0);
    Console.Write(min);
    Console.Write(":");
}
else
{
    Console.Write(min);
    Console.Write(":");
}

if (sec < 10)
{
    Console.Write(0);
    Console.WriteLine(sec);
}
else
{
    Console.WriteLine(sec);
}

Console.WriteLine("***************************************");