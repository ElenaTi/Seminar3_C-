/* Напишите программу, которая принимает на вход число N и выдает 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N + 1; i++)
{
    int cube = i * i *i;
    if (i == N)
    {
        Console.Write($" {cube}");
    }
    else
    {
        Console.Write($" {cube},");
    }
}