// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int SumMtoN(int start, int end)
{
    if (start == end) return end;
    return start + SumMtoN(start + 1, end);
}
if (M < N) Console.WriteLine(SumMtoN(M, N));
else Console.WriteLine("Введите натуральное значение M, меньше значения N");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}
Console.WriteLine(Akkerman(n, m));



// Задача 62. Заполните спирально массив 4 на 4.


int n = 4;
int m = 4;
int[,] matrix = new int[n, m];
int row = 0;
int column = 0;
int dx = 1;
int dy = 0;
int directoryChanges = 0;
int visits = m;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, column] = i + 1;
    if (--visits == 0)
    {
        visits = m * (directoryChanges % 2) + n * ((directoryChanges + 1) % 2) - (directoryChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        directoryChanges++;
    }

    column += dx;
    row += dy;
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}