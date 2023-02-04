
//    Написать программу, которая в двумерном массиве заменяет строки 
// на столбцы или сообщить что это невозможно (в случае, если матрица не квадратная).



void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] matrix)
{
    int[,] changeMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            changeMatrix[j, i] = matrix[i, j];
        }
    }

    return changeMatrix;
}

Console.Write("Введите количество строк  массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов  массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);

if(rows == columns)
{
     int[,] changeMatrix = ChangeArray(matrix);
    Console.WriteLine("Замена  строк на столбцы прошла успешно, получаем матрицу: ");
    PrintArray(changeMatrix);
}
else
{
    Console.WriteLine("В матрице невозможно заменить строки на столбцы , так как она не квадратная.");
   
}         