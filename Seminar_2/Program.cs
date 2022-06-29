// Задача 1
// Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа

// int numberA = new Random().Next(10, 99);         // Это раздел, где описываются и задаются начальные условия стр 5-8.
// Console.WriteLine(numberA);
// int firstnum = numberA / 10;
// int secondnum = numberA % 10;

// void CompareNumber(int firstnum, int secondnum)  // Здесь объявляется функция, т.е. описывается, что она будет с заданными аргументами
// {
// if (firstnum > secondnum)
// {
//     Console.WriteLine(firstnum+ " больше чем " +secondnum);
// }
// else
// {
//     Console.WriteLine(secondnum+ " больше чем "  +firstnum);
// }
// }

// CompareNumber(firstnum, secondnum);  // Здесь описанная функция вызывается с указанными аргументами (), т.е. дается команда на её выполнение.


// void randomNumberCompare(int start, int finish);  // Объявление функции
// {
//     int numberA = new Random().Next(start, finish);
// }


// Задача 2
// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

// Вариант 1
// int numberA = new Random().Next(100, 999);
// Console.WriteLine(numberA);
// int firstnum = numberA / 100;
// int thirdnum = numberA % 10;
// Console.WriteLine(firstnum * 10 + thirdnum);

// Вариант 2 (решение через функцию)
// int sumthing(int start, int finish)
// {
//     int numberA = new Random().Next(start, finish);
//     Console.WriteLine(numberA);
//     int firstnum = numberA / 100;
//     int thirdnum = numberA % 10;
//     int result = (firstnum * 10 + thirdnum);
//     Console.WriteLine(result);
//     return result;
// }

// sumthing(100, 999);

// int A = sumthing(100, 999);
// Console.WriteLine(A);

// Задача3
// Console.WriteLine("Введите првое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = number2 % number1;
// if(result == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

// void multiple(int num1, int num2)
// {
//     if (num2 % num1 == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else
//     {
//         Console.WriteLine("Не кратно" + (num2 / num1));
//     }
// }

// multiple(25, 10);

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[num];
// for (int i = 0; i < 0; i++);
// {
//     array[i] = i;
//     Console.WriteLine(array[i]);
// }

// int num = Convert.ToInt32(Redline());
// string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
// Console.WriteLine(weekDays[num-1]);
// ------------------------------------------------------------------------------------------
// ДЗ ко второму семинару:

// Задача №10

// Вариант решения №1
// Console.Write("Введите трехзначное число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int secondNum = Math.Abs(number1 % 100 - number1 % 10) / 10;
// Console.WriteLine(secondNum);

// Вариант решения №2

int showSecDigit(int threeDigNum)
{
    Console.WriteLine($"Ваше число: {threeDigNum}.");
    int secDigit = Math.Abs(threeDigNum % 100 - threeDigNum % 10) / 10;
    Console.Write($"Мы нашли вторую цифру Вашего числа, и это цифра: {secDigit}. ");
    return secDigit;
}

showSecDigit(195);
