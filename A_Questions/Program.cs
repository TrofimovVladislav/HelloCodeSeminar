/*---------------------------------------------------------
Задача 23
Напишите программу, которая принимает на вход 
число (N)  и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
// int[] cube()
// {
//     Console.WriteLine("Введите число: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int[] result = new int[N];
//     for (int i = 1; i <= N; i++)  // в расчет не берется значеение = N?
//     {
//         result[i - 1] = i * i * i;
//         // result[i-1] = Math.Pow(i, 3); // VSC ругается, что не double?
//         Console.WriteLine(result[i-1]); // Без этой строки код не работает?
//     }
//     return result;
// }

// cube();


// Найти сумму чисел от 1 до N.
// int hasSum()
void hasSum()
{
    Console.WriteLine("Введите число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= A; i++) sum += i;
    
    Console.WriteLine(sum);   // void выводит значение sum без return?
    // return sum;            // при intнужен return?
}

hasSum();

