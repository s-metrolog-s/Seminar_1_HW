// Задача 3. На ввод подаётся рост трёх спортсменов. 
//           Расположить их от большего к меньшему.

//double s1 = 1.78;
//double s2 = 1.65;
//double s3 = 1.83;

double s1 = 1.35;
double s2 = 1.85;
double s3 = 1.83;

double max = s1;
double middle = s1;
double min = s1;

if (s2 > max) max = s2;
if (s3 > max) max = s3;

if (s2 < min) min = s2;
if (s3 < min) min = s3;

if ((s2 < max) && (s2 > min)) middle = s2;
if ((s3 < max) && (s3 > min)) middle = s3;

Console.WriteLine(max);
Console.WriteLine(middle);
Console.WriteLine(min);