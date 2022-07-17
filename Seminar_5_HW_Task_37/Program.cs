/*------------------------------------------------------------------------
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// int sumNumbersOddIndex(int length)
// {
//     int[] arrNumbers = new int[length];
//     Random rnd = new Random();

//     int sumNumOdd = 0;

//     for (int i = 0; i < length; i++)
//     {
//         arrNumbers[i] = rnd.Next(-100, 100);
//         Console.Write(arrNumbers[i] + " ");

//         if (i % 2 != 0) sumNumOdd = sumNumOdd + arrNumbers[i];
//     }

//     Console.WriteLine();
//     Console.WriteLine("Сумма элементов с нечетными индексами в заданном массиве = {0}.", sumNumOdd);

//     return sumNumOdd;
// }

// Console.WriteLine();
// Console.WriteLine("Решение Задачи № 36:");

// sumNumbersOddIndex(7);

// Вариант Елены

int N = 10;
int[] arr = new int[N];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < N; i++)
{
    arr[i] = rnd.Next(-10, 10);
    Console.Write(arr[i] + " ");

    if (i % 2 == 1) // Запись вместо i % 2 = 1 т.к. результат i % 2 условно четный.
    {
        sum += arr[i];
        Console.WriteLine(sum);
    }
}
