
   //Задать двумерный массив следующим правилом: Aₘₙ = m+n: .



Console.Write("Введите количество строк двумерного массива m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = matrix[i, j] = i + j;
        
        System.Console.Write($"{matrix[i, j]} ");  // Console.WriteLine($"{matrix[i, j] = i + j}");
    }
        System.Console.WriteLine();
}




/////////////////////////////////////

