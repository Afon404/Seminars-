

    //      В двумерном массиве заменить элементы, 
    //    у которых оба индекса чётные на их квадраты: .
///////////////////////////////////////////////////////////////////////////////////


Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
}

void ChangeArray(int[,] array)
{
    for (int ChangeNumA = 0; ChangeNumA < array.GetLength(0); ChangeNumA++)
    {
        for (int ChangeNumB = 0; ChangeNumB < array.GetLength(1); ChangeNumB++)
        {
            if (ChangeNumA % 2 == 0 && ChangeNumB % 2 == 0)
                array[ChangeNumA, ChangeNumB] *= array[ChangeNumA, ChangeNumB];
        }
    }
}



int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine("======================");
ChangeArray(array);
PrintArray(array);

////////////////////

