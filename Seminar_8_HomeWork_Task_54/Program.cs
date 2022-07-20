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

void SortMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, j] > matrix[k, j + 1])
                {
                    int temp = matrix[k, j];
                    matrix[k, j] = matrix[k, j + 1];
                    matrix[k, j + 1] = temp;
                }
            }
        }
    }
}

PrintMatrix(inputArray, rows, columns);
SortMatrix(inputArray, rows, columns);
PrintMatrix(inputArray, rows, columns);


