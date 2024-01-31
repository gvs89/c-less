﻿

int [] CreateArray (int size, int max, int min){
            int [] array  = new int[size];
            Random rand = new ();
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

int [] array = CreateArray(10, 10, 0);


Console.WriteLine("[" + PrintArray(array) + "]");
Console.WriteLine("[" + PrintArray(ArraySwap(array,array.Length-1)) + "]");