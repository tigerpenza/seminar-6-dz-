// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter {i + 1} the number: ");
            newArray[i] = Convert.ToInt32(Console.ReadLine());

        }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " | ");
    Console.WriteLine();
}


void aboveZero( int[] array)
{
    int count = 0;
    for( int i = 0; i < array.Length; i++)
        if( array[i] > 0) count++;
    Console.WriteLine($"There were of {count} numbers greater than zero: ");
}


Console.WriteLine("Enter number of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
ShowArray(newArray);
System.Console.WriteLine();
aboveZero(newArray);






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2-b1) / (k1-k2);
    double y = k2 * x + b2;
    if(k1 == k2) Console.Write("Lines are parallel");
    else Console.Write($"Intersection point: x: {x}, y: {y}");
}

Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Intersection(k1, b1, k2, b2);