// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetBinaryArr(int size)
{
    int[] resultArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArr[i] = new Random().Next(100, 1000);
    }
    return resultArr;
}

int[] arr = GetBinaryArr(8);
int evenCount = 0;
int GetBinaryArrLenght = 8;
for (int j = 0; j < GetBinaryArrLenght; j++)
{
    if (arr[j] % 2 == 0) evenCount++;
}

Console.WriteLine($"[{String.Join(" ;", arr)}]");
Console.Write($" количество чётных чисел --> {evenCount}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[6];
int sumResult = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);


for (int j = 1; j< array.Length; j +=2)
{
    sumResult = sumResult + array[j];
}
Console.WriteLine($"[{String.Join(" ;", array)}], сумма равна = {sumResult}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] arr = new double[7];
double differenceResult = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
}

double maxNum = arr[0];
double minNum = arr[0];

for (int j = 1; j < arr.Length; j++)
{
    if (arr[j] > maxNum)
        maxNum = arr[j];
    if (arr[j] < minNum)
        minNum = arr[j];
}
differenceResult = maxNum - minNum;
Console.WriteLine($"[{String.Join(" ;", arr)}], разница равна = {differenceResult}");