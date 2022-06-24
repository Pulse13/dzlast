Console.WriteLine("Введите трёхзначное число: ");
int f = Convert.ToInt32(Console.ReadLine());
int K = 0;
if(f>=100 && f<1000)
{
    K = f%10;
    Console.WriteLine(K);
}
else
{
    Console.WriteLine("Ошибка.Введите трёхзначное число");
}