//massiv
//int n = 10;

int[] array = { 1, 5, 3, 4, 7, 6, 9, 3, 41, 2 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");

    }
    i = i + 1;
}

int i = 0;
int count = 0;
while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        count++

        }
    i = i + 1;
}
result count



