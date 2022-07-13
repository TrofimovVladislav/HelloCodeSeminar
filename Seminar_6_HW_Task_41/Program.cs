/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Console.WriteLine("Введите через запятую любые пять целых чисел: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] numbersArray = new int[5];


// Console.Write("Введите длину: ");

// int usL = Convert.ToInt32(Console.ReadLine());

int[] a = new int[5];
// Console.WriteLine("Числа: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write("Числа: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    }
Console.Write("Массив: ");
for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + " ");
}

