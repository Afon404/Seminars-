
//    В Указанном массиве вещественных чисел найдите разницу 
//    между максимальным и минимальным элементом



Console.Clear();
string min = "Минимальное значение массива = ";
string max = "Mаксимальное значение массива = ";
Console.WriteLine();

// int size = new Random().Next(1, 11);  // можно рандомно
Console.Write("Введите массив:\t");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количетсов элементов массива: {size}");

int[] FillSourceArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next() * 100;
    }
    return array;
}

void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    int difference = arr.Max() - arr.Min();
    Console.WriteLine($"{min} {arr.Min()}\n{max} {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();