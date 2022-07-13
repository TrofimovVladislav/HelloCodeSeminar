// Задача 39 переворот массива

// int[] arr = new int[] 



// Задача 40 Проверяет по трем числам может ли быть такой треугольник с такими сторонами.
// int numA = 100;
// int numB = 10;
// int numC = 10;


// bool ChekA = numA < numB + numC;
// bool ChekB = numB < numA + numC;
// bool ChekC = numC < numA + numC;
// if (ChekA && ChekB && ChekC)
// {
//     Console.WriteLine("Треугольник сущ");
// }
// else{
// Console.WriteLine("Не сущ");
// }

// Задача 44
// Не использую рекурсию 

// Задача 45

int[] arr = new int[5] { 1, 2, 3, 4, 5 };

int[] getArrayCopy(int[] arr)
{
    int N = arr.Length;
    int[] copy = new int[N];

    for (int i = 0; i < N; i++)
    {
        copy[i] = arr[i];
        Console.Write(copy[i] + " ");
    }
    
    return copy;
}

getArrayCopy(arr);

