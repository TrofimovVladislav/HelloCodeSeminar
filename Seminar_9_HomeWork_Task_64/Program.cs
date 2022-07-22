// Задача 64: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

int[,] natNumbers = new int[M, N];

for (int i = 0; i < natNumbers.GetLength(1); i++)
{   
    string Error = (" Ошибка ввода. Число M не может быть " +
    "меньше ноля и больше числа N.\n Введите другое число.");
    int num = M;
    if (M <= 0 || M >= N)
    {
        Console.WriteLine(Error);
        return;
    }

    else num = num + i;
    Console.Write(num + " ");
    
}
Console.WriteLine();