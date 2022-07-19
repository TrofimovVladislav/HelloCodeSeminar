// Задача 53: 
// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// Console.WriteLine("Ведите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Ведите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// if(rows != columns)
// {
//     Console.ReadLine("Заменять элементы массивы нельзя");
//     return;
// }

// void PrintArray (int [,] inputArray);
// for (int i = 0; i < inputArray.GetLength(1); i++)
// {
//     result[i,j]
// }

// void ChangeRows (int [,] matrix)
// {
//     int numberLastRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1  ); i++)
//     {
//         int temp = matrix [0,i];
//         matrix [0,i] = matrix[numberLastRow];

//     }matrix[numberLastRow] = temp;
// }
// ChangeRows(array);
// Console.WriteLine("Результат");
// PrintArray(array);

// int [] array = {1,2,3,4,5};

// Console.WriteLine($"[{String.Join("; ", array)}]"); // [1,2,3,4]
// void PrintReverseArray(int[,] inputArray)
// {
    
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
            
//             Console.Write(inputArray[j, i] + "\t"); //inputArray[i,j] + "    "
//             // 1    2    3    4
//             // 5    3    2    1
//         }
// Console.Write("\n");
//     }
// }

// Console.WriteLine("Результат: ");
// PrintReverseArray(array);
// Задача 59.
// Задайте двумерный массив из целых чисел. Н
// апишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// int rows = 3;
// int columns = 3;

// int [,] matrix = new int [rows, columns];

// int minValue = int.MaxValue; // matrix [0,0]
// int inexRows = 0;
// int indexColumns = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {   
//         matrix[i,j] = new Random().Next(11);
//         if (minValue > matrix[i,j])
//         {
//             minValue = matrix[i,j];
//             indexRows = i;
//             indexColumns = j;
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Минимум " + minValue);

// for (int i = 0; i < rows; i++)
// {
//     if(i != indexRows)
//     {
//     for (int j = 0; j < columns; j++)
//     {
//         if (j != indexColumns)
//         {
// Console.WriteLine(matrix[i,j + "\t"]);
//         }
//     }
//     Console.WriteLine();
// }
// }

// int rows = 3;
// int columns = 3;
 
// int[,] matrix = new int[rows, columns];
 
// int minValue = int.MaxValue; //Значение минимального элемента
// int minIndexRows = 0;        //Задание индекса минимального элемента (строчка)
// int minIndexColumns = 0;     //Задание индекса минимального элемента (столбец)
 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(11); // [0,10]
//         Console.Write(matrix[i, j] + "\t");
//         if (minValue > matrix[i, j])
//         // minValue = 5(пусть)
//         // 5>0, то минимум уже не 5, minValue = 0
//         {
//             minValue = matrix[i, j];
//             minIndexRows = i;
//             minIndexColumns = j;
//  }
 
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимум:" + minValue);
// System.Console.WriteLine("Результат:");
// for (int i = 0; i < rows; i++) // rows = GetLength(0)
// {
//     if (i != minIndexRows)
//     {
//         for (int j = 0; j < columns; j++) //columns - GetLength(1)
//         {
//             if (j != minIndexColumns)
//             {
//                 Console.Write(matrix[i,j] + "\t");
 
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
