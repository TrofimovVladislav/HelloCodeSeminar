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

// Задача №22

// Console.WriteLine("Введите число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int[] numSqrt = new int[numN];
// for (int i = 1; i <= numN; i++)
// {
//     numA[i - 1] = i * i; // Массив новый для результата
//     Console.WriteLine(numA[i - 1]);
// }

// Console.WriteLine("Введите число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int[] numSqrt = new int[numN];
// int i = 1;
// while (i <= numN)
// {
//     Console.WriteLine(numA[i - 1]);
//     i++;
// }

int[] findeNumSqrt(int numN)
{
    Console.WriteLine("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    int[] numSqrt = new int[numN];
    int i = 1;
    while (i <= numN)
    {
        numSqrt[i-1] = i*i;
        Console.WriteLine(numSqrt[i - 1]);
        i++;
        return numSqrt;
    }
}
int[] result = findeNumSqrt(5);