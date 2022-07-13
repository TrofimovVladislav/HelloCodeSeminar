/*
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
