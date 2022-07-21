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

int[,,] inputArray = new int[rows, columns, page];

Random rnd = new Random();

for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        for (int k = 0; k < inputArray.GetLength(2); k++)
        {
            inputArray[i, j, k] = rnd.Next(0, 15);
        }
    }
}
Console.WriteLine();

void PrintArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        // Console.WriteLine();
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {

            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write("{0} ({1}, {2}, {3}) \t", inputArray[i, j, k], i, j, k);
            }
        }
        Console.WriteLine();
    }
}

PrintArray(inputArray);
