/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int quontEvenDigit(int length)
{
    int[] arrNum = new int[length];
    Random rnd = new Random();

    int count = 0;

    for (int i = 0; i < length; i++)
    {
        arrNum[i] = rnd.Next(100, 1000);
        Console.Write(arrNum[i] + " ");

        if (arrNum[i] % 2 == 0) count++;
    }

    Console.WriteLine();
    Console.WriteLine("Количество четных чисел в заданном массиве = {0}.", count);

    return count;
}

Console.WriteLine();
Console.WriteLine("Решение Задачи № 34:");

// // quontEvenDigit(10);

// /*------------------------------------------------------------------------
// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// */

int sumNumbersOddIndex(int length)
{
    int[] arrNumbers = new int[length];
    Random rnd = new Random();

    int sumNumOdd = 0;

    for (int i = 0; i < length; i++)
    {
        arrNumbers[i] = rnd.Next(-100, 100);
        Console.Write(arrNumbers[i] + " ");

        if (i % 2 != 0) sumNumOdd = sumNumOdd + arrNumbers[i];
    }

    Console.WriteLine();
    Console.WriteLine("Сумма элементов с нечетными индексами в заданном массиве = {0}.", sumNumOdd);

    return sumNumOdd;
}

Console.WriteLine();
Console.WriteLine("Решение Задачи № 36:");

sumNumbersOddIndex(7);


/*------------------------------------------------------------------------
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

double hasDifMaxMinNums(int length)
{
    double[] arrNums = new double[length];
    Random rnd = new Random();

    double numMin = 0;
    double numMax = 0;
    double difMaxMin = 0;

    for (int i = 0; i < length; i++)
    {
        arrNums[i] = rnd.Next(-100, 100);
        Console.Write(arrNums[i] + " ");

        if (arrNums[i] > numMax) numMax = arrNums[i];
        if (arrNums[i] < numMin) numMin = arrNums[i];
    }

    difMaxMin = numMax - numMin;

    Console.WriteLine();
    Console.WriteLine("Максимальное число массива = {0}", numMax);
    Console.WriteLine("Минимальное число массива = {0}", numMin);
    Console.WriteLine("Разница между макимальным и минимальным числом массива = {0}", difMaxMin);
    Console.WriteLine();

    return difMaxMin;
}

Console.WriteLine();
Console.WriteLine("Решение Задачи № 38:");

hasDifMaxMinNums(10);
