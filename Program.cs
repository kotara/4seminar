// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void MetFindDigit (int a, int b)
{   int result = 1;
    for (int i = 1; i <= b; i++)
    result = result*a;
    
    Console.WriteLine($" {a} to the extent {b} is {result}");
}

Console.WriteLine("Input your number A: ");
int user_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your number B: ");
int user_b = Convert.ToInt32(Console.ReadLine());

if (user_b >= 1)
{
    MetFindDigit(user_a, user_b);
}
else
    Console.WriteLine("Impossible value");
    */


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void MetFindSum (int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + (a % 10);
        a = a / 10; 
    }
    Console.WriteLine($"Sum of digits your number is {sum}");
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
MetFindSum(user_num);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateRandomArray (int size, int minVal, int maxVal)   //  метод создания массива размером size со значениями от minVal до maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}


void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i]+ " ");
        Console.WriteLine();
}
int sizeStart = 8;
int minPossibleVal = 1;
int maxPossibleVal = 999;
int [] arrayStart = CreateRandomArray(sizeStart, minPossibleVal, maxPossibleVal); // созхдали рандомный массив
ShowArray(arrayStart); // продемонстрировали исходный массив