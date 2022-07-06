// int findeSumNum(int numA)
// {
// int result = 0;
// for(int i = 1; i <=numA; i++)
// {
//     result += i;
// }
// Console.WriteLine(result);
// return result;
// }

// findeSumNum(5);


// int digitCount(int n)
// {
//     int result = 0;
//     int div = 1;
//     while ((n / div) >= 1)
//     {
//         div *= 10;
//         result += 1;
//     }
//     Console.WriteLine(result);
//     return result;
// }

// digitCount(2);
// digitCount(12);
// digitCount(132);
// digitCount(2456);

// int proizv(int num1)
// {
//     int result = 1;
//     for(int i = 1; i <= num1; i++)
//     {
//         result *= i;
//     }

//     Console.WriteLine(result);
//     return result;
// }
// proizv(5);

// int[] arr()
// {
//     int[] result = new int[8];
//     for(int i=0; i<8; i++)
//     {
//         int A = (new Random()).Next(0,2);
//         result[i]= A;

// Console.Write(result[i] + " ");
//     }
//     return result;
// }
// arr();

int[] numbersSqrt()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ваше число: " + num);
    Console.WriteLine("Квадраты чисел от 1 до " + num);
    int i = 1;
    int[] sumSqrt = new int[num];

    while (i <= num)
    {
        sumSqrt[i - 1] = i * i;
        Console.WriteLine(sumSqrt[i-1]);
        i++;
    }
    return sumSqrt;
}
numbersSqrt();


