// Задача 58: 
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите число строк исходных матриц № 1 и № 2: ");
int rowsBothArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов исходных матриц № 1 и № 2: ");
int columnsBothArray = Convert.ToInt32(Console.ReadLine());

int[,] inputFirstArray = new int[rowsBothArray, columnsBothArray];
int[,] inputSecondArray = new int[rowsBothArray, columnsBothArray];

Random rnd = new Random();

void PrintMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] resultArray = new int[rowsBothArray, columnsBothArray];

void ProductTwoArray(int[,] matrixFirst, int[,] matrixSecond)
{
    for (int i = 0; i < rowsBothArray; i++)
    {
        for (int j = 0; j < columnsBothArray; j++)
        {
            resultArray[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
            Console.Write(resultArray[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Исходная матрица №1: \n");
PrintMatrix(inputFirstArray, rowsBothArray, columnsBothArray);
Console.WriteLine("Исходная матрица №2: \n");
PrintMatrix(inputSecondArray, rowsBothArray, columnsBothArray);
Console.WriteLine("Результат произведения матриц №1 и №2: \n");
ProductTwoArray(inputFirstArray, inputSecondArray);
