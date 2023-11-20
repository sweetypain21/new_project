// See https://aka.ms/new-console-template for more information
//Console.Write("Введите ваше имя");
//string ? username=Console.ReadLine();
//Console.Write("Hello, World!");
//Console.WriteLine(username);

//int a=5;
//int b=9;
//Console.WriteLine(a+b);

//Console.Write("Введите 1 число");
//int  number_1=3;
//Console.Write("Введите 2 число");
//int number_2=5;
//Console.Write("Сумма чисел равна");
//Console.WriteLine(number_2+number_1);


//double numberA=12;
//double number_2=5;
//Console.WriteLine(numberA/number_2);

//int a=new Random().Next(1,10);
//Console.WriteLine(a);
//int b=new Random().Next(0,100);
//Console.WriteLine(b);
//Console.WriteLine(a+b);

//Console.Write("Введите имя пользователя ");
//string? username=Console.ReadLine();
//if(username.ToLower()=="маша")
//{
//    Console.WriteLine("Привет,любимая Маша");
//}
//else
//{
// Console.Write("Привет новый пользователь");
//}

//int a=1;
//int b=1;
//int c=6;
//int d=8;
//int e=4;
//int max=a;
//if(a>max) max=a;
//if(b>max) max=b;
//if(c>max) max=c;
//if(d>max) max=d;
//if(e>max) max=e;
//Console.WriteLine(max);


//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
/*

int xa =1;
int ya=1;
int xb=1;
int yb=30, xc=40,yc=30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");

int x=xa, y=xb, count=0;
while(count <1000)
{
    int what=new Random().Next(0,3);
    if(what==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }

    if(what==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if(what==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}

Console.WriteLine("Введите число:");
int number=Convert.ToInt32(Console.ReadLine());
int sqare=number*number;
Console.WriteLine($"Квадрат вашего числа {number}={sqare}");



Console.WriteLine("Введите 1 число:");
int number_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int number_2=Convert.ToInt32(Console.ReadLine());
if(number_2*number_2==number_1)
{
    Console.WriteLine("Один из ваших чисел является квадратным корнем второго");
}
else
{Console.WriteLine("У вас обычные числа");}

ФУНКЦИИ  И МАССИВЫ 
int[] array={1,2,3,4,5,6,7,8,9,10,18};

int n=array.Length;
int index=0;
int find=19;
while (index<n)

{
    if (array[index]==find)
{
    Console.WriteLine(index);
}
index++;
}




using System.Collections.ObjectModel;
void array(int[] collection)
{
    int lenght=collection.Length;
    int index=0;
    while (index<lenght)
    {
        collection[index]=new Random().Next(1,101);
        index++;
    }
}


using System.Collections.ObjectModel;

void FillArray(int[] collection)
void PrintArray(int[] col)

{
    int count=Collection.length;
    int posotion=0;
    while (Position< count)
    {
        Console.WriteLine(col[position]);
        position++
    }
}
int[] array= new int[10];
FillArray(array);
PrintArray(array); 
*/
int Max(int arg1,int arg2,int arg3)
{
    int result =arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}
int a1=10;
int a2=1;
int a3=9;
int b1=3;
int b2=4;
int b3=2;
int c1=2;
int c2=9;
int c3=10;
int max1=Max(a1,a2,a3);
int max2=Max(b1,b2,b3);
int max3=Max(c1,c2,c3);
int max=Max(max1,max2,max3);
Console.WriteLine(max);