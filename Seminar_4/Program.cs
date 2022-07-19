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

// Task 19 Palindrom
// bool isPalindrom(int x)
// {
//     int div = 1;
//     while (x / div <= 10)
//     {
//         div *= 10;
//     }
//     Console.WriteLine(div);
//     while (x != 0)
//     {
//         int l = x / div;
//         int r = x % 10;
//         if (l != r)
//         {
//             Console.WriteLine("Not Palindrom");
//             return false;
//         }

//         x = (x % div) / 10;
//         div /= 100;
//     }
//     Console.WriteLine("Palindrom");
//     return true;
// }
// isPalindrom(1598951);

// Task 19 light version

// bool isPalindromLight(int[] arr)
// {
//     bool result = false;
//     int N = arr.Length;
//     for (int i = 0; i < N / 2; i++)
//     {
//         if (arr[i] != arr[N - i - 1])
//         {
//             Console.WriteLine("Not Palindrom");
//             return result;
//         }
//         result = true;
//         Console.WriteLine("Palindrom");

//         return result;
//     }
// }

// isPalindromLight(1235321);

// получить массив из ReadLine
// int [] arr = Array.ConvertAll(Console.ReadLine()).Split(''), int.Parse);
// isPalindromLight(arr);