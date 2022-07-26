// Задача 68: 
// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29 
// !!! В в условии задачи, в ответе - опять ошибка!!!
// Результат вычисления функции Аккермана от (2, 3) = 9, а не 29 !!!

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FuncAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));

    return FuncAkkerman(m, n);
}

Console.WriteLine("Результат вычисления функции Аккермана с аргументами "
                  + $"(m = {m}, n = {n}) = {FuncAkkerman(m, n)}; \n");
FuncAkkerman(m, n);