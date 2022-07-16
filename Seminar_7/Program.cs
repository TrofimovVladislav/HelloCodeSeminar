// Задача 46

// Console.WriteLine("Введите количество столбцов: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[M, N];

// Random rnd = new Random();

// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < N; j++)
//     {
//         array[i, j] = rnd.Next(1, 100);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 48
Console.WriteLine("Введите количество столбцов: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M, N];


for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}

// Задача 51

// int [,] Numbers = new int [4,3];
// Random rnd = new Random ();
// int sum = 0;
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         if (i == j) 
//         {
//             Numbers [i, j] = rnd.Next(-10, 10);
//             sum = sum + Numbers[i,j];
//         }
//  Console.WriteLine(Numbers[i,j] + " ");
//     }
//     Console.WriteLine();
// }

int [,] array = 