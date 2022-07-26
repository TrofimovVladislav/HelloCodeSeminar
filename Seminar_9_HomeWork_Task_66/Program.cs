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

int NumbersSum(int start, int end)
{
    if (start == end) return start;
    return (start + NumbersSum(start + 1, end));
}

Console.WriteLine($"Сумма чисел от {M} до {N} = " + NumbersSum(M, N));