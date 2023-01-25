

  //  Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран



// int[] num =  {0, 1, 0, 1, 1, 1, 0, 0};

// foreach (int A in num)
// {
//     Console.Write("Массив из 8 заданых чисел мною: ");
//     Console.WriteLine($"Elements: {A} ");
// }





///////////////////////////////////////

                    //Вариант 2:



// int Length = 8;
// int min = 0;
// int max = 1;

// int[] Do_Array(int Length, int min , int max )
// {
//     int[] arr = new int[Length];
//     for (int i = 0; i < Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }

// PrintArray(Do_Array(Length, min, max));


////////////////////////    /// Вариант 3:






// int[] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(min, max + 1);

//     return array;    
// }

// void PrintArray(int[] array)
// {
//     foreach (int element in array)
//         Console.Write(element + " ");
// }

// int[] array = CreateArray(8, 0, 1);
// Console.WriteLine("Массив случайных чисел от 0 до 1: ");
// PrintArray(array);