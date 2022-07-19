// Задача 50: 
// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк M и стобцов N:");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индексы искомого элемента i0 и j0:");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        {
            array[i, j] = rnd.Next(-100, 100);
            Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

if (i0 >= M || j0 >= N)
{
    Console.WriteLine("Числа с такими индекасами в текущем массиве нет.");
}
else
{
    Console.WriteLine("Элементом с идексами i0 = {0} и j0 = {1} является число {2}.", i0, j0, array[i0, j0]);
    Console.WriteLine();
}

