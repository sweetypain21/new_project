//Задача №1
// Напишите программу, которая на вход принимает
//два числа и выдаёт, какое число большее, 
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using System.ComponentModel.DataAnnotations;

int a=-9;
int b=-3;
int max=0;
if(a>b)
{
    max=a;
}
else
{
    max=b;
}
Console.WriteLine("Задача №2");
Console.Write("max=");
Console.WriteLine(max);
Console.WriteLine();

//Задача №4
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
int Max(int arg1,int arg2,int arg3)
{
    int result =arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}
int z=2;
int x=3;
int v=7;
int maximum=Max(z,x,v);
Console.WriteLine("Задача №4");
Console.Write("maximum=");
Console.WriteLine(maximum);
Console.WriteLine();


//Задача №6
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
int l=4;
if (l%2==0)
{   
    Console.WriteLine("Задача №6");
    Console.WriteLine("Число на ввод чётное");
}
else
{   
    Console.WriteLine("Задача №6");
    Console.WriteLine("Число на ввод нечётное");
}
Console.WriteLine();

//Задача 8:
// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Задача №8");
Console.WriteLine("Введите число");
int p=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<p;i++)
{
    //int[]array={};
    if (i%2==0)
    {
        //array.Append(i);
        Console.WriteLine("Четное число до заданного числа");
        Console.WriteLine(i);

    }
}
