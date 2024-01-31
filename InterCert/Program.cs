/////////////////Task_1

string ShowDigit(int firstDigit, int secondDigit)
{
    if (firstDigit > secondDigit)
    {
        return "";
    }
    return $"{firstDigit} " + ShowDigit(firstDigit + 1, secondDigit);
}


Console.WriteLine("Введите число M:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Числа от {firstNum} до {secondNum} => {ShowDigit(firstNum, secondNum)}");

/////////////////Task_2

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }
}

Console.WriteLine("Введите число m:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение по фукнкции Аккермана ({firstNumber},{secondNumber}) = {Ack(firstNumber, secondNumber)}");

///////////////////Task_3

int[] CreateArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}

int[] array = CreateArray(10, 10, 0);
System.Console.WriteLine("[" + PrintArray(array) + "]");
System.Console.WriteLine("[" + PrintArray(ArraySwap(array, array.Length - 1)) + "]");