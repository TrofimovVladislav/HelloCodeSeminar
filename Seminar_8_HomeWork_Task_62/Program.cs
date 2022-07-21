// Задача 62. 
// Заполните спирально массив 4 на 4.
// Например, на выходе получается 
// вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.WriteLine("Введите число строк спирального массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов спирального массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] inputArray = new int [4, 4] {{1,2,3,4}, {5,6,7,8}, {9,10,11,12}, {13,14,15,16}};

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(inputArray [i, j] + " \t"); 
    }
    Console.WriteLine();
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 0; j++)
    {
        for (i = 0; i < 4; i++)
        {
            Console.Write(inputArray [i,j] + " \t"); 
        }
        Console.Write(inputArray [i,j] + " \t"); 
    }
    Console.WriteLine();
}

// https://renkport.ru/java/primer/zapolnenie-dvumernogo-massiva-po-spirali/