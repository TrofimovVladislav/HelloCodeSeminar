// n! = 1 .... n
// int Factorial(int num)
// {
//     if (num == 1) return 1; // Фактриал от 1 = 1(1*1)
//                             // базовый случай для рекурсии
//     return (num * Factorial(num - 1));
// }


// Базовый случай - он позволяет выйти из рекурсииЮ условие выхода
// Рекурсивный случай - место, откуда повторно вызывается функция

// string Hello()
// {
//     Hello();
//     return "Hello";
// }

// Hello();

// Задача 63: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите N");
// int N = Convert.ToInt32(Console.ReadLine():)
// string PrintNumbers(int sart, int end)
// {
//     // Базовый случай
//     if(start == end) return start.ToString();
//     // Рекурсивный случай
//     return (start +  ", " + PrintNumbers(start=1, end));
// }

// Console.WriteLine(PrintNumbers(1, end));

// Задача 65: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if(start == end) return start.ToString();
    // Рекурсивный случай
    return (start +  ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(M, N));

// Задача 67: 
// Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
// if(num==0) return 0; //Базовый случай
// return (number % + SumNumbers(number/10)); // рекурсивный случай    
// }

// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = Convert.ToInt32(Console.ReadLine());

// int power = Convert.ToInt32(Console.ReadLine());

// int Power(int num, int pow)
// {
//     // Базовый случай
//     if(pow==1) return num;
//     // Рекурсивный случай
//     return(num * Power(num, pow-1));
// }

// Console.WriteLine(Power(number, power));