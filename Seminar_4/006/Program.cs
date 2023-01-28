
        // Найти произведение пар чисел в одномерном массиве.
        // Парой считаем первый и последний элемент, второй и предпоследний и т.д.


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;    
}

void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write(element + " ");
}

int EnterValue(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void MetodA(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length / 2; i++)  //
    {
            int elementA = array[i];
            int elememtB = array[array.Length - i - 1];
            sum = elementA * elememtB;
            Console.WriteLine($"Произведение пары {i} и {array.Length - i - 1} элементов массива равно: {elementA} * {elememtB} = {sum}");    
    }
}

int size = EnterValue("Введите размер массива: ");
int min = EnterValue("Введите минимальное число в массиве: ");
int max = EnterValue("Введите максимальное число в массиве: ");

int[] array = CreateArray(size, min, max);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();

MetodA(array);

                                         




///////////////////////////////////////////////////////////////////////////////////////



                      // Черновик:




// Console.Clear();
// System.Console.WriteLine();
// Console.WriteLine("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите минимальное число массива: ");
// int min = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите максимальное число массива: ");
// int max = int.Parse(Console.ReadLine()!);


//     int sum = min + max ;
// Console.WriteLine($"{sum}");
// Console.WriteLine($"Количество элементов массива: {size}");




// первый вариант - собираем новый массив из произведений пар.
// В случае, если количество элементов исходного массива нечетное, среднее значение массива "выпадает" из обработки

// int[] GetPairProduct(int[] data)
// {
//     int[] product = new int[data.Length / 2];
//     int last = data.Length - 1;
//     for (int i = 0; i < data.Length / 2; i++)
//     {
//         product[i] = data[i] * data[last];
//         last = last - 1;
//     }
//     return product;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] array = FillArray(size, min, max);
// PrintArray(array);

// System.Console.WriteLine();
// System.Console.WriteLine("Первый вариант:");
// PrintArray(GetPairProduct(array));

// воторой вариант с выводом среднего числа (если количество элементов массива нечетное)

// void PrintProductPairs(int[] dataArray)
// {
//     int last = dataArray.Length - 1;
//     for (int i = 0; i < dataArray.Length / 2; i++)
//     {
//         System.Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
//         last--;
//     }
//     if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Второй вариант:");
// PrintProductPairs(array);



/////////////////////////////



///////////////////////////////////////////////////