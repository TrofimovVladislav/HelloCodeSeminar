/*---------------------------------------------------------------------------------------
Задача 25: 
Напишите программу, которая принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine();
Console.WriteLine("Решение задачи 25:");
int numberPow(int A, int B)
{
    int result = (int)Math.Pow(A, B);
    Console.WriteLine("Значение числа " + A + " в степени " + B + " = " + result + ";");
    return result;
}

numberPow(3, 5);
numberPow(2, 4);

/*--------------------------------------------------------------------------------------
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine();
Console.WriteLine("Решение задачи 27:");
int findSum(int num)
{
    int num1 = num, x = 10;
    while (num1 > 10)
    {
        num1 = num1 / x;
        x *= 10;
    }

    int div = x, sum = 0;
    while (div != 0)
    {
        int result = (num / div) % 10;
        sum = sum + result;
        div /= 10;
    }

    Console.WriteLine($"Сумма цифр числа {num} = {sum};");
    return sum;
}
findSum(452);
findSum(82);
findSum(9012);

Console.WriteLine();

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Вариант 1:
Console.WriteLine("Решение задачи 29 (Вариант 1):");
void PrintArray(int N)
{
    Console.WriteLine("Искомый массив: ");

    int[] arr = new int[8] { 1, 2, 5, 7, 19, 6, 1, 33 };
    int i = 1;

    while (i <= N)
    {
        Console.Write(arr[i - 1] + ", ");
        i++;
    }

    Console.WriteLine();
}

PrintArray(8);
Console.WriteLine();
// Вариант 2 (Random):
//-----------------------------------------------------------------------
Console.WriteLine("Решение задачи 29 (Вариант 2: Random):");
void PrintArray2(int N)
{
    Console.WriteLine("Искомый массив: ");
    int[] printN = new int[N];
    int i = 1;
    Random rand = new Random();
    while (i <= N)
    {
        int numN = rand.Next(1, 99);
        printN[i - 1] = numN;
        Console.Write(printN[i - 1] + ", ");
        i++;
    }
    Console.WriteLine();
}

PrintArray2(8);
Console.WriteLine();