/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

// double hasDifMaxMinNums(int length)
// {
//     double[] arrNums = new double[length];
//     Random rnd = new Random();

//     double numMin = 0;
//     double numMax = 0;
//     double difMaxMin = 0;

//     for (int i = 0; i < length; i++)
//     {
//         arrNums[i] = rnd.Next(-100, 100);
//         Console.Write(arrNums[i] + " ");

//         if (arrNums[i] > numMax) numMax = arrNums[i];
//         if (arrNums[i] < numMin) numMin = arrNums[i];
//     }

//     difMaxMin = numMax - numMin;

//     Console.WriteLine();
//     Console.WriteLine("Максимальное число массива = {0}", numMax);
//     Console.WriteLine("Минимальное число массива = {0}", numMin);
//     Console.WriteLine("Разница между макимальным и минимальным числом массива = {0}", difMaxMin);
//     Console.WriteLine();

//     return difMaxMin;
// }

// Console.WriteLine();
// Console.WriteLine("Решение Задачи № 38:");

// hasDifMaxMinNums(10);


// Альтернативное решение через индекс минимального
// маскимального числа

// double[] num = new double[5] { 3, 7, 22, 2, 78 };
// int imax = 0;
// int imin = 0;
// double result = 0;
// for (int i = 0; i < 5; i++)
// {
//     if (num[i] > num[imax])
//     {
//         imax = i;
//     }
//     else if (num[i] < num[imin])
//         imin = i;
//     result = num[imax] - num[imin];
// }
// Console.WriteLine(result);

// Вариант Елены

// int N = 10;
// double[] arr = new double[N];
// Random rnd = new Random();
// double diff = 0;

// for (int i = 0; i < N; i++)
// {
//     arr[i] = rnd.Next(100, 1000);
// }

// double max = arr[0], min = arr[0];
// for (int i = 0; i < N; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }
// diff = max - min;

// Вариант Елены через индексы

int imax= 0, imin = 0; 
int N = 10;
double diff= 0;
double[] arr = new double[N];
Random rnd = new Random();

for (int i = 0; i <N; i++)
{
 arr[i] = rnd.Next(10,1000);

 if(arr[i] > arr[imax])
 imax = i;
 if(arr[imin] < arr[imin])
 {
    imin = i;
 }
}
diff = arr[imax] - arr[imin];