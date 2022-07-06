
// ДЗ к Семинару №3

// ---------------------------------------------------------------------
/*Задача 19
Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void isPalindrom(int num)
{
string numA = num.ToString();
char[] arrNumA = numA.ToCharArray();
Array.Reverse(arrNumA);
string numB = new string(arrNumA);
Console.WriteLine(num);
if (numA == numB) Console.WriteLine("Это число Палиндром");
else Console.WriteLine("Это число не Палиндром");
}

isPalindrom(14212);
Console.WriteLine();
isPalindrom(12821);
Console.WriteLine();
isPalindrom(23432);
Console.WriteLine();

/* -------------------------------------------------------------------------------
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double hasLength(double xa, double ya, double za, double xb, double yb, double zb)
{
    if (xa == xb && ya == yb && za == zb) return 0;

    double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return result;
}
double d = hasLength(3, 6, 8, 2, 1, -7);
Console.WriteLine(d);
double d1 = hasLength(7, -5, 0, 1, -1, 9);
Console.WriteLine(d1);

/*---------------------------------------------------------
Задача 23
Напишите программу, которая принимает на вход 
число (N)  и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//------------------------------------------------
// Вариант 1 (for)

int[] hasCube(int num)
{
    Console.WriteLine("Ваше число: " + num);
    Console.WriteLine($"Кубы чисел от 1 до {num}:");
    int[] numsQube= new int[num];

    for (int i = 1; i <= num; i++)
    {
        numsQube[i - 1] = i * i * i;
        Console.WriteLine(numsQube[i - 1]);
    }

    return numsQube;
}

hasCube(3);
Console.WriteLine();
hasCube(5);

//-----------------------------------------------------
// Вариант 2 (While, Math.Pow)

int[] findeNumQube(int numN)
{
    int[] numQube = new int[numN];
    int i = 1;
    Console.WriteLine("Кубы цифр от 1 до " + numN + ":");

    while (i <= numN)
    {
        numQube[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write(numQube[i - 1] + ", ");
        i++;
    }

    Console.WriteLine();
    return numQube;
}

findeNumQube(3);
findeNumQube(5);

