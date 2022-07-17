// ДЗ к Семинару 6 Варианты Елены
// Задача №41

// int M = Convert.ToInt32(Console.ReadLine());
// int countOfPositives = 0;

// for (int i = 0; i < M; i++)
// {
//     int digit = Convert.ToInt32(Console.ReadLine());
//     if (digit > 0) countOfPositives++;
// }

// Console.WriteLine("Positives: {0}", countOfPositives);

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// Преобразуем y = k1*x + b1, y = k2*x + b2;
// k1*x + b1 = k2*x + b2
// k1*x - k2*x = b2 - b1
// x*(k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1 - k2)
// y = x*k1 + b1

// void getCoordinates(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = x * k2 + b2;
//     Console.WriteLine("Пересечение {0}, {1}", x, y);
// }

// getCoordinates(2, 5, 4, 9);

// Семинар №7

// Задача 46: Задайте двумерный массив размером m×n, з
// аполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[M, N];

// Random rnd = new Random();

// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < N; j++)
//     {
//         array[i, j] = rnd.Next(1, 100);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// // Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество столбцов: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[M, N];


// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < N; j++)
//     {
//         array[i, j] = i + j;
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите количество столбцов: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[M, N];
// Random rnd = new Random();
// int M = 3, N = 4;
// int[,] array = new int[,]{{0,1,2,3}, {4,5,6,7}, {8, 9, 10, 11}};

// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < N; j++)
//     {
//         // array[i, j] = rnd.Next(1, 10);
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }

//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите ширину и длину массива.");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M, N];

int sum = 0;
Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
        if (i == j)
        {
            sum = sum + array[i, j];
        }
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Сумма элементов главной диагонали массива = {0}", sum);