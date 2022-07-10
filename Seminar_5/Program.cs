/*-------------------------------------------------------------------------
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

// int lenght = 12;
// int[] newArr = new int[lenght];
// Random rnd = new Random();
// int positivesSum = 0;
// int negativesSum = 0;

// for (int i = 0; i < lenght; i++) {
//     newArr[i] = rnd.Next(-9, 10);
//     Console.Write(newArr[i] + " ");
//     if (newArr[i] > 0) {
//         positivesSum = positivesSum + newArr[i];
//     } else if (newArr[i] < 0) {
//         negativesSum = negativesSum + newArr[i];
//     }
// }
// Console.WriteLine(Results:);
// Console.WriteLine("Positives Sum: {0}, npositivesSum);
// Console.WriteLine("Negatives Sum: {0}, negativesSum);

// -------------------------------------------------------------
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int lenght = 5;
// int[] newArr = new int[lenght];
// Random rnd = new Random();
// for (int i = 0; i < lenght; i++)
// {
//     newArr[i] = rnd.Next(-9, 10);
//     Console.Write(newArr[i] + "  ");
//     Console.Write(newArr[i] * -1);
//     Console.WriteLine();
// }

/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
 4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

// bool anser(int num)
// {
//     int[] newArr = new int [7] {8, 9, 63, 4, 8, 4, 6};
//     bool ans = false;

//     for(int i = 0; i < newArr.Length; i++)
//     {
//         if(newArr[i] == num)
//         {
//             return true;
//         }
//     }
//     return ans;
// }

// bool A = anser(63);
// Console.WriteLine(A);

/*-------------------------------------------------------------
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

// int length = 50;
// int[] newArr = new int[length];
// Random rnd = new Random();
// int num = 0;

// for (int i = 0; i < length; i++)
// {
//     newArr[i] = rnd.Next(-25, 25);
//     Console.Write(newArr[i] + ",  ");
//     if (newArr[i] >= 20 & newArr[i] <= 30)
//     {
//         num++;
//     }
// }

// Console.WriteLine();
// Console.WriteLine("num = {0}", num);

/*------------------------------------------------------------------------
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int length = 5;
int[] newArr = new int[5] { 1, 2, 3, 4, 5 };

int resultlength = 0;
if (length % 2 == 0)
{
    resultlength = length / 2;
}
else
{
    resultlength = length / 2 + 1;
}

int[] result = new int[resultlength];


for (int i = 0; i < length/2; i++)
{
    result[i] = newArr[i] * newArr[length - i - 1];
}

if (length % 2 != 0)
{
    result[resultlength - 1] = newArr[length / 2];
}

for (int i = 0; i < resultlength; i++)
{
    Console.Write(result[i] + " ");
}