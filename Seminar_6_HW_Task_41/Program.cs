/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Write("Какое количество чисел Вы хотите ввести? ");
int userArrayLength = Convert.ToInt32(Console.ReadLine());
int[] m = new int[userArrayLength];

for (int i = 0; i < m.Length; i++)
{
    Console.Write("Введите " + userArrayLength + " целых чисел: ");
    m[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}

Console.WriteLine("Ваши числа: ");

for (int i = 0; i < m.Length; i++)
{
    Console.Write(m[i] + " ");
}

int count = 0;
for (int i = 0; i < m.Length; i++)
{
    if (m[i] > 0) count++;
}

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine();
Console.WriteLine("Количество чисел больше ноля = " + count + ".");
