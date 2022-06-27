// Console.WriteLine("Введите число, ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(numberA);
// int pow = numberA * numberA;
// Console.WriteLine(pow);

// Задача 2

// Console.WriteLine("Введите первое число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberB == numberA*numberA)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача 4 Неделя

// Console.WriteLine("Введите номер дня недели: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if (numberA == 1)
// {
//     Console.WriteLine("Понедельнк");
// }
// if (numberA == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if (numberA == 3)
// {
//     Console.WriteLine("Среда");
// }
// if (numberA == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if (numberA == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if (numberA == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if (numberA == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// if (numberA > 7 || numberA < 1)
// {
//     Console.WriteLine("Ошибка");
// }

// Console.WriteLine("Введите номер дня недели");
// int? input =  Convert.ToInt32(Console.ReadLine());

//     switch (input)
//     {
//         case 1:
//             Console.WriteLine("Понедельник");
//             break;
//         case 2:
//             Console.WriteLine("Вторник");
//             break;
//         case 3:
//             Console.WriteLine("Cреда");
//             break;
//         case 4:
//             Console.WriteLine("Четверг");
//             break;
//         default:
//             Console.WriteLine("Ошибка");
//             break;
//     };

// ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 23.06.2022г.
// #Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}, min = {numberB}");
}
else 
{
    Console.WriteLine($"max = {numberB}, min = {numberA}");
}

// Задача 4: 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Первый вариант решения

Console.Write("Введите первое чило: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB & numberA > numberC)
{
    Console.WriteLine($"max = {numberA};");
}
else
{
    if (numberB > numberA & numberB > numberC)
        Console.WriteLine($"max = {numberB};");
    else
    {
        Console.WriteLine($"max = {numberC};");
    }
}
    // Второй вариант решения

    Console.Write("Введите первое чило: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите вторе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int numberC = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"max = {Math.Max(numberA, Math.Max(numberB, numberC))};");

// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int numberEven = Convert.ToInt32(Console.ReadLine());
if (numberEven % 2 == 0)
{
	Console.WriteLine("Это число ЧЕТНОЕ"); 
}
else
{
	Console.WriteLine("Это число НЕЧЕТНОЕ");
}

// Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.Write($"{i}, ");
