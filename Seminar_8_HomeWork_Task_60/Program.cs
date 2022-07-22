// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int page = Convert.ToInt32(Console.ReadLine());

int[,,] GetTripleArray(int rows, int columns, int page, int minRandom, int maxRandom)
{
    int[,,] array = new int[rows, columns, page];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(minRandom, maxRandom);
            }
        }
    }

    return array;
}

int[,,] inputArray = GetTripleArray(rows, columns, page, 0, 100);

void PrintArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write("\n");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write("{0} ({1}, {2}, {3}) \t", inputArray[i, j, k], i, j, k);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
    }
}

GetTripleArray(rows, columns, page, 0, 100);
PrintArray(inputArray);
