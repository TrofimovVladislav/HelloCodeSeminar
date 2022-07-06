// Задача №17

// void quarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("Это первая четверть");
//     }
//     else
//         if (x < 0 && y > 0)
//     {
//         Console.WriteLine("Это вторая четверть");
//     }
//     else
//         if (x < 0 && y < 0)
//     {
//         Console.WriteLine("Это третья четверть");
//     }
//     else
//         if (x > 0 && y < 0)
//     {
//         Console.WriteLine("Это четвертая четверть");
//     }
// }
// quarter(2, 4);
// quarter(-2, 4);
// quarter(-2,-4);
// quarter(2,-4);

// Задача №18

// Console.WriteLine("Введите номер четверти: ");
// int quarterNum = Convert.ToInt32(Console.ReadLine());
// if (quarterNum == 1)
// {
//     Console.WriteLine("Поле координат: x > 0, y > 0;");
// }
// if (quarterNum == 2)
// {
//     Console.WriteLine("Поле координат: x < 0, y > 0;");
// }
// if (quarterNum == 3)
// {
//     Console.WriteLine("Поле координат: x < 0, y < 0;");
// }
// if (quarterNum == 4)
// {
//     Console.WriteLine("Поле координат: x > 0, y < 0;");
// }

// double findeLengthAB (double xa, double ya, double xb, double yb)
// {
//     // double result = 0;
//     // return result;
//     if(xa==xb && ya==yb)
//     {
//         return 0;
//     }
//     double result = Math.Sqrt(Math.Pow(xb - xa,2) + Math.Pow(yb - ya, 2));
//     return result;
// }
// double L = findeLengthAB (7, -5, 1, -1);
// Console.WriteLine(L);

//--------------------------------------------------------------
// Задача №22
// Найти квадраты чисел от 1 до N

// Console.WriteLine("Введите число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int[] numSqrt = new int[numN];
// for (int i = 1; i <= numN; i++)
// {
//     numSqrt[i-1] = i * i; // Массив новый для результата
//     Console.Write(numSqrt[i - 1]);
// }

// Console.WriteLine("Введите число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int[] numSqrt = new int[numN];
// int i = 1;
// while (i <= numN)
// {
//     numSqrt[i-1] = Convert.ToInt32(Math.Pow(i, 3));
//     Console.WriteLine(numSqrt[i - 1]);
//     i++;
// }

// int[] findeNumSqrt(int numN)
// {
//     int[] numSqrt = new int[numN];
//     int i = 1;
//     while (i <= numN)
//     {
//         numSqrt[i - 1] = i * i;
//         Console.WriteLine(numSqrt[i - 1]);
//         i++;
//     }
//     return numSqrt;
// }

// int[] result = findeNumSqrt(3);


// string[] WeekDay = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// Console.WriteLine("Введите номер дня недели: ");
// int weekDayNumber = Convert.ToInt32(Console.ReadLine());


// Вариант для нахождения 3-ей цифры числа любой разрядности (вариант Елены)

// void hasThirdNumber(int x)
// {
//     int div = 1;
//     while (x / div >= 10)
//     {
//         div *= 10;
//         Console.WriteLine(div);
//     }

//     if (div < 100)
//     {
//         Console.WriteLine("Too little Number");
//     }
//     else
//     {   // Last number of x / (div/100)  123456
//         int digit = (x / (div / 100)) % 10;
//         Console.WriteLine("Third is {0}", digit);
//     }
// }

// hasThirdNumber(12);
// hasThirdNumber(129);
// hasThirdNumber(1234);
// hasThirdNumber(12545);
// hasThirdNumber(123456);

// ---------------------------------------------------------------------
/*Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// m1: Console.WriteLine("Введите пятизначное число: ");
// int polindrom = Convert.ToInt32(Console.ReadLine());
// string num1 = polindrom.ToString();
// if (num1.Length != 5) goto m1;
// char[] polArr = num1.ToCharArray();
// Array.Reverse(polArr);
// num1 = new String(polArr);
// int polindrom2 = Convert.ToInt32(num1);
// if (polindrom == polindrom2) Console.WriteLine("Это число Полиндром");
// else Console.WriteLine("Это число не Полиндром");

// Console.WriteLine(polArr);

// void isPolindrom(int number)
// {
//     // int polindrom = Convert.ToInt32(Console.ReadLine());
//     string number1 = number.ToString();
//     char[] polArr = number1.ToCharArray();
//     Array.Reverse(polArr);
//     string num1 = new String(polArr);
//     int polindrom2 = Convert.ToInt32(num1);
//     if (number == polindrom2) Console.WriteLine("Это число Полиндром");
//     else Console.WriteLine("Это число не Полиндром");
//     Console.WriteLine(polArr);
// }
// // isPolindrom(5624881);

/* -------------------------------------------------------------------------------
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// double hasLength(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     if (xa == xb && ya == yb && za == zb) return 0;

//     double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
//     return result;
// }
// double d = hasLength(3, 6, 8, 2, 1, -7);
// Console.WriteLine(d);
// double d1 = hasLength(7, -5, 0, 1, -1, 9);
// Console.WriteLine(d1);

/*---------------------------------------------------------
Задача 23
Напишите программу, которая принимает на вход 
число (N)  и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// int[] findeNumQube(int numN)
// {
//     int[] numQube = new int[numN];
//     int i = 1;
//     while (i <= numN)
//     {
//         numQube[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
//         Console.Write(numQube[i - 1] + ", ");
//         i++;
//     }
//     return numQube;
// }
// Console.WriteLine("Кубы цифр от 1 до 3:"); 
// int[]numQube = findeNumQube(3);
// Console.WriteLine();
// Console.WriteLine("Кубы чисел от 1 до 5:");
// int[]numQube1 = findeNumQube(5);

// Найти кубы чиселот1 до N.
// int[] hasCube()
// {
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Ваше число: " + num);
//     Console.WriteLine($"Кубы чисел от 1 до {num}:");
//     int[] result = new int[num];
//     for (int i = 1; i <= num; i++)
//     {
//         result[i - 1] = i * i * i;
//         Console.WriteLine(result[i - 1]);
//     }
//     return result;
// }

// hasCube();

// Найти сумму целых чисел от 1 до N

// int hasSum()
// {
//     Console.WriteLine("Введите число: ");
//     int A = Convert.ToInt32(Console.ReadLine());
//     int sum = 0;
//     int i = 1;
//     while (i <= A)
//     {
//         sum = sum + i;
//         i++;
//     }
//     Console.WriteLine(sum);
//     return sum;
// }
// hasSum();

void hasSum()
{
    Console.WriteLine("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    int sum = 1;

    for (int i = 1; i <= A; i++) sum *= i;
    
    Console.WriteLine(sum);
    // return sum;
}
hasSum();
