/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write("Какое количество чисел Вы хотите ввести? ");
int userArrayLength = Convert.ToInt32(Console.ReadLine());
int[] M = new int[userArrayLength];

for (int i = 0; i < M.Length; i++)
{
    Console.Write("Введите " + userArrayLength + " целых чисел: ");
    M[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine("Ваши числа: ");

for (int i = 0; i < M.Length; i++)
{
    Console.Write(M[i] + " ");
}

int count = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0) count++;
}

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine();
Console.WriteLine("Количество чисел больше ноля = " + count + ".");
