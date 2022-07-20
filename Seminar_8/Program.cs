// Задача 53: 
// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// Console.WriteLine("Ведите количество строк массива: ");
// // int rows = int.Parse(Console.ReadLine()); // аналог Convert.ToInt32 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите количество строк массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// /// summary (описание методов, обозначается трмя ///)
// /// матрица (двумерный массив) задается как m на n, 
// /// m - количество строк, n - количество столбцов.
// /// minRandom, maxRandom
// int[,] GetArray(int m, int n, int minRandom, int maxRandom) // пример метода на вывод двумерного массива
// {
//     int[,] result = new int[m, n]; // m имеет начальный индекс - 0, n - индекс 1.
//     for (int i = 0; i < result.GetLength(0); i++) // проходим цикл по строкам
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//     }

//     return result;
// }

// int[,] array = GetArray(rows, columns, 0, 10);

// void PrintArray(int [,] inputArray) // пример метода по выводу массива на печать
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//          Console.Write(inputArray[i,j] + "\t");    
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array);

// void ChangeRows(int [,] matrix)
// {
//     int numberLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i] = matrix[numberLastRow,i];
//         matrix[numberLastRow,i] = temp;
//     }
// }

// ChangeRows(array);
// Console.WriteLine("Результат: ");
// PrintArray(array);

// int [] array = {1,2,3,4,5};
// Console.WriteLine($"[{String.Join("; ", array)}]"); // [1; 2; 3; 4; 5]

// Задача 55: 
// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна 
// вывести сообщение для пользователя.

// Console.WriteLine("Ведите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите количество строк массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows != columns)
// {
//     Console.WriteLine("Заменять элементы массив нельзя");
//     return; // в данном случае return при нвеерном вводе условия
//             // будет ожидать ввода правильного условия (пустой return)
// }

// int[,] GetArray(int m, int n, int minRandom, int maxRandom)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(minRandom, maxRandom + 1);
//         }
//     }

//     return result;
// }

// int[,] array = GetArray(rows, columns, 0, 10);

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array);

// void PrintReversArray(int[,] inputArray)
// {
//     // int[,] resultArray = new int[i, j]; альтернативный вариант с созданием доп массива
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             // resultArray [i, j] = inputArray[j, i]; и заполнение его перевернутым входящим
//             Console.Write(inputArray[j, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Результат: ");
// PrintReversArray(array);

// Задача 57: 
// Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию
// о том, сколько раз встречается элемент входных данных.

//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Задача 59: 
// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns];

int minValue = int.MaxValue; // matrix [0, 0]
int indexRows = 0;           // индекс строки с минималным элементом
int indexColumns = 0;        // индекс столбца с минимальным элементом

for (int i = 0; i < matrix.GetLength(0); i++) // rows
{
    for (int j = 0; j < matrix.GetLength(1); j++) // columns
    {
        matrix[i, j] = new Random().Next(11); // [0, 10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        {
            minValue = matrix[i, j];
            indexRows = i;
            indexColumns = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Минимальный элемент: " + minValue); // just for testing

// Здесь вместо matrix.GetLength(0) применяем rows, т.е. уже известное значение 
// переменнойБ чтобы не нагружать код
// Или ввести пременную длины массива int sizeRows = matrix.GetLength(0);
for (int i = 0; i < rows; i++)
{
    if (i != indexRows)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j != indexColumns)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}

