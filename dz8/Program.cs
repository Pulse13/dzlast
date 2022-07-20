// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
double [,] arr = new double [rows,columns];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = new Random().NextDouble()*100;
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите позиции элемента массива через пробел");
int [] position = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine("Введите размер массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arr = new int [rows,columns];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = new Random().Next(0,11);
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}
if (position[0] <= arr.GetLength(0) - 1 && position[1] <= arr.GetLength(1)-1)
{
    Console.WriteLine($"Наш элемент равен: {arr[position[0],position[1]]}");
}
else
{
    Console.WriteLine($"Элемента с позицией {arr[position[0],position[1]]} нет");
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = Int32.Parse(Console.ReadLine());
int columns = Int32.Parse(Console.ReadLine());
int [,] arr = new int [rows,columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr [i,j] = new Random().Next(0,5);
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}
double [] average = new double [columns];
for (int k = 0; k < columns; k++)
{
    for (int l = 0; l < rows; l++)
    {
        average [k] = average[k] +arr[l,k];
    }
    average [k] = average[k]/rows;
}
Console.WriteLine($"[{String.Join(";", average)}]");


