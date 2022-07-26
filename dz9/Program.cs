
Console.WriteLine("Введите кол-во строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] arr = GetArray(rows, columns, 1, 7);
PrintArray(arr);


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Decrease(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }

        }
    }
}
Decrease(arr);
Console.WriteLine("Массив в порядке убывания: ");
PrintArray(arr);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[] sum = new int [rows];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        sum[i] = sum[i]+ arr[i,j];
    }
}
Console.WriteLine($"Сумма строк равна:  {String.Join(";", sum)}");
int minSumString = 0;
int minSum = int.MaxValue;
for (int i = 0; i < rows-1; i++)
{
    if (minSum>sum[i])
    {
        minSumString = i;
        minSum = sum[i];
    }
}
Console.WriteLine($"Ответ- строка №  {minSumString+1}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("2ой массив: ");
int[,] secondArr = GetArray(rows, columns, 1, 7);
PrintArray(secondArr);
void ArrMultiplication(int[,] array1, int [,] array2, int [,] arrMultiplication)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrMultiplication[i,j] = array1[i,j]*array2[i,j];
            Console.Write(arrMultiplication[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int [,] arrayMultiplication = new int [rows,columns];
Console.WriteLine($"Массив произведения: ");
ArrMultiplication(arr,secondArr,arrayMultiplication);



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine($"Введите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}