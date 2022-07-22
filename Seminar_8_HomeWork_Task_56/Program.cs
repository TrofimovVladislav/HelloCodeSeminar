// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Ведите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите количество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int rows, int columns, int minRandom, int maxRandom)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }

    return array;
}

int[,] inputArray = GetArray(rows, columns, 0, 10);

void PrintMatrix(int[,] matrix, int rows, int columns)
{
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetRowsMinSum(int[,] matrix, int rows, int columns)
{
    int sumMin = int.MaxValue; int minSumRowIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + inputArray[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            minSumRowIndex = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: {0} строка.", minSumRowIndex);
}

GetArray(rows, columns, 0, 10);
PrintMatrix(inputArray, rows, columns);
GetRowsMinSum(inputArray, rows, columns);
