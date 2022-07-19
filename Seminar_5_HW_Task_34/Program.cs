/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// int quontEvenDigit(int length)
// {
//     int[] arrNum = new int[length];
//     Random rnd = new Random();

//     int count = 0;

//     for (int i = 0; i < length; i++)
//     {
//         arrNum[i] = rnd.Next(100, 1000);
//         Console.Write(arrNum[i] + " ");

//         if (arrNum[i] % 2 == 0) count++;
//     }

//     Console.WriteLine();
//     Console.WriteLine("Количество четных чисел в заданном массиве = {0}.", count);

//     return count;
// }

// Console.WriteLine();
// Console.WriteLine("Решение Задачи № 34:");

// quontEvenDigit(10);

// Вариант Елены

// int N = 10;
// int[] arr = new int[N];
// Random rnd = new Random();
// int count = 0;
// for (int i = 0; i < N; i++)
// {
//     arr[i] = rnd.Next(100, 1000);
//     if (arr[i] % 2 == 0)
//     {
//         count++;
//     }
// }


