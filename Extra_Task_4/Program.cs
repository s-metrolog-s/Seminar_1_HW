// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
// N = 72334 -> 20:5:34 

int N = 72334;
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

Console.Write(hour);
Console.Write(":");
Console.Write(min);
Console.Write(":");
Console.WriteLine(sec);
Console.WriteLine("***************************************");