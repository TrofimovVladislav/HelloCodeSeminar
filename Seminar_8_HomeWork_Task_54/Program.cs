// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// int minValue = int.MaxValue;
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write(array[i, j] + "\t");
//         // if (array[0, j] < minValue)
//         // {
//         //     int temp = array[0, j];
//         //     array[0, j] = minValue;
//         //     minValue = temp;
//         // }
//         // Console.Write(array[0, j] + " ");
//     }
//     Console.WriteLine();
// }

int[,] inputArray = new int[3, 4] { { 3, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = 3;
int columns = 4;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(inputArray[i, j] + "\t");
    }
    Console.WriteLine();
}


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns - 1; j++)
    {
        for (int k = 0; k < rows; k++)
        {
            if (inputArray[k, j] < inputArray[k, j + 1])
            {
                int temp = inputArray[k, j];
                inputArray[k, j] = inputArray[k, j + 1];
                inputArray[k, j + 1] = temp;
            }
        }
    }
}
Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(inputArray[i, j] + "\t");
    }
    Console.WriteLine();
}

// https://nicknixer.ru/programmirovanie/algoritm-puzyrkovoj-sortirovki-odnomernogo-massiva-na-c/

// https://csharp.webdelphi.ru/laboratornaya-rabota-po-c-sortirovka-dvumernogo-massiva-metodom-puzyrka/

// for (int i = 0; i < arrLength; i++)
// {
//     for (int j = 0; j < arrLength - 1; j++)
//     {
//         if (array[j] > array[j + 1])
//         {
//             int temp = array[j];
//             array[j] = array[j + 1];
//             array[j + 1] = temp;
//         }
//     }
// }
// Console.WriteLine();

// for (int i = 0; i < arrLength; i++)
// {
//     Console.Write(array[i] + " ");
// }

// Console.WriteLine();