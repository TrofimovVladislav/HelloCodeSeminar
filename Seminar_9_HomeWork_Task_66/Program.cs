// Задача 66:
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumRangeOfNumbers(int start, int end)
{
    int sum = 0;
    for (int i = 0; i <= N; i++) sum = sum + i;
    // if (start == end) return start;
    // return (start + SumRangeOfNumbers(start, end));
    return sum;
}

Console.WriteLine(SumRangeOfNumbers(M, N));



//     int sum = 0;
//     for (int i = 0; i <= N; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
//     // return (start + SumRangeOfNumbers(start + 1, 0));
// }
// // SumRangeOfNumbers (M, N);
// Console.WriteLine(SumRangeOfNumbers(M, N));