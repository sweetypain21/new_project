//Задача 10: Напишите программу, 
//которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число:");
int m=Convert.ToInt32(Console.ReadLine());
if ((m>=100) & (m<=999))
{
    int v=(m/10)%10;
    Console.Write("Вторая цифра числа-");
    Console.WriteLine(v);
}
else
{
    Console.WriteLine("Извините, вы ввели не правильное число");
}
//Задача 13: Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число, а я угадаю его 3 цифру:");
int e=Convert.ToInt32(Console.ReadLine());
if (e<100)
{
    Console.WriteLine("Третьей цифры у числа нет");
    
}
if (e>=100 & e<=999)
{
    int w=(e%10);
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(w);
}
if (e>=1000 & e<10000)
{    int w=(e%100)/10;
    Console.Write("Третья цифра числа");
    Console.WriteLine(w);
}
if (e>=10000 & e<100000)
{    int w=(e%1000)/100;
    Console.Write("Третья цифра числа");
    Console.WriteLine(w);
}
if (e>=100000 & e<10000000)
{    int w=(e%10000)/1000;
    Console.Write("Третья цифра числа");
    Console.WriteLine(w);
}

// №13 Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
var weekdays = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Восресенье"},
};
*/
Console.WriteLine("Введите номер дня недели:  ");
int vvedennya_cifra=Convert.ToInt32(Console.ReadLine());
if (vvedennya_cifra==1)
{
    Console.WriteLine("Понедельник- будний день");
}
if (vvedennya_cifra==2)
{
    Console.WriteLine("Вторник- будний день");
}
if (vvedennya_cifra==3)
{
    Console.WriteLine("Среда- будний день");
}
if (vvedennya_cifra==4)
{
    Console.WriteLine("Четверг- будний день");
}
if (vvedennya_cifra==5)
{
    Console.WriteLine("Пятница- будний день");
}
if (vvedennya_cifra==6)
{
    Console.WriteLine("Суббота- выходной день");
}
if (vvedennya_cifra==7)
{
    Console.WriteLine("Воскресенье- будний день");
}

