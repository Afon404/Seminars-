
//  Показать двумерный массив размером m×n заполненный вещественными числами.


Console.WriteLine("Введите 2 числа, чтобы задать размерность массива");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
Random random = new Random();
int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = random.Next(-10, 10);
    }

}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"\t| {matrix[i, j]} |\t");
    }
    Console.WriteLine(" ");

}


 
///////////////////////////////////////////