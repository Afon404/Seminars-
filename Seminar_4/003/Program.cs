﻿
    //    Задать массив, заполнить случайными положительными трёхзначными числами. 
   //     Показать количество нечетных\четных чисел

/////////////////////////////////////////////////////////////////


Console.Clear();
Console.WriteLine();


int size = 20;

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else odd++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {odd}");
    Console.WriteLine();
}

PrintResult(Array(size));

///////////////////////////////////////////////////////////////////////////////

