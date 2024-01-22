// int CreateArray(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         array[i] = rnd.Next(0, 100);
//     }
//     return arr;
// }

// bool IsSimple(int n)
// {
//     for (int i = 2; i < n; i++)
//     {
//         if (n % i == 0)
//         {
//             return false;
//         }

//     }
//     return true;
// }

// int GetPrimeQuantity(int[] array)
// {
//     int countPrimes = 0;
//     foreach (int e in array)
//     {
//         bool res = IsSimple(e);
//         if (res == true)
//         {
//             countPrimes = countPrimes + 1;
//         }

//     }
//     return countPrimes;
// }


// Console.WriteLine("size");
// int n = Int32.Parse(Console.ReadLine());
// int[] CreateArray = CreateArray(n);

// int count = GetPrimeQuantity(arr);
// Console.WriteLine(count);
void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e}  ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);