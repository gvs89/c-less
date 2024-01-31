//Task_1

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 10;
        Console.WriteLine(PrintNaturalNumbers(M, N));
    }

    static string PrintNaturalNumbers(int M, int N)
    {
        if (M >= N)
            return "";
        else
        {
            Console.WriteLine(M);
            return PrintNaturalNumbers(M + 1, N);
        }
    }
}
//Task_2
class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (n == 0)
            return Ackermann(m - 1, 1);
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        Console.WriteLine(Ackermann(3, 4));
    }
}

///////////////////Task_3
int [] CreateArray (int size, int max, int min){
            int [] array  = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                array [i] = rand.Next(min,max+1);
            }
            return array;
        }
string PrintArray(int [] array)
        {
            return string.Join(", ",array);
        }
int [] ArraySwap(int [] array,int index)
        {

            if (index <= 0)
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - index-1];
            array[array.Length - index-1] = temp;
            return ArraySwap(array,index -= 2);
        }

int [] array = CreateArray(10,10,0);
System.Console.WriteLine("[" + PrintArray(array) + "]");
System.Console.WriteLine("[" + PrintArray(ArraySwap(array,array.Length-1)) + "]");