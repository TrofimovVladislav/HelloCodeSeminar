// Задача 39
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] arr = new int[5] { 1, 2, 3, 4, 5 };
// int len = arr.Length;

// for (int i = 0; i < len; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// for (int i = 0; i < len / 2; i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[len - i - 1];
//     arr[len - i - 1] = temp;
// }

// Console.WriteLine();

// for (int i = 0; i < len; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите длинну сторно треугольника: A, B, C.");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());

// bool ChekA = A < B + C;
// bool ChekB = B < A + C;
// bool ChekC = C < A + B;
// if (ChekA && ChekB && ChekC)
// {
//     Console.WriteLine("Треугольник с такими параметрами может существовать.");
// }
// else{
// Console.WriteLine("Треугольник с такими параметрами не может существовать.");
// }

// Задача 42: 
// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int num = 10;
// int t = 0, d = 1;
// while (num > 0)
// {
//     t += (num % 2) * d;
//     num = num / 2;
//     d = d * 10;
// }
// Console.WriteLine(t);



// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// fib(n) = fib(n-1) + fib(n-2)


// int fibonacci(int n)
// {
//     if (n == 1 || n == 2)
//     {
//         return 1;
//     }

//     return fibonacci(n - 1) + fibonacci(n - 2);
// }

// fibonacci(5);

// void writeFibonacci(int n)
// {
//     int fib1 = 0;
//     int fib2 = 1;
//     int sum = 0;
//     if (n >= 1)
//     {
//         Console.Write(fib1 + " ");
//     }
//     if (n >= 2)
//     {
//         Console.Write(fib2 + " ");
//     }

//     int i = 0;
//     while (i < n - 2)
//     {
//         sum = fib1 + fib2;
//         Console.Write(sum + " ");
//         fib1 = fib2;
//         fib2 = sum;
//         i++;
//     }
// }

// int N = 5;
// writeFibonacci(N);

// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] arr = new int[5] { 1, 2, 3, 4, 5 };
int[] getArrayCopy(int[] arr)
{
    int N = arr.Length;
    int[] copy = new int[N]; 

    for (int i = 0; i < N; i++)
    {
        copy[i] = arr[i];
        Console.Write(copy[i] + " ");
    }

    return copy;
}

int [] result = getArrayCopy(arr);
Console.WriteLine();

