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

int[,] inputArray = new int[3, 4] { { 3, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int rows = 3;
int columns = 4;
void PrintMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintMatrix(inputArray, rows, columns);

int sumMin = int.MaxValue; int rowIndex = 0;
for (int i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum = sum + inputArray[i, j];
    }
if(sum < sumMin)
{
sumMin = sum;
rowIndex = i;
Console.WriteLine("Сумма по строке {0} = {1}", rowIndex, sumMin);
}

// Console.WriteLine($"Сумма по строке = " + minSum);
}



