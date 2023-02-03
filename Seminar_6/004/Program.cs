
// Написать программу, которая обменивает элементы первой строки и последней строки:




Random  random = new Random();  // заполняем матрицу случайными числами
int n = 4, m = 5;    
int[,] matrix = new int[n, m];  // Создаём матрицу размерностью NxM
int i, j, temp;             // Объявлем целочисленные переменные
Console.WriteLine("Рандомная матрица:");
for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        matrix[i, j] = random.Next(100);   //   каждому элементу матрицы  присваиваем случайное число
        Console.Write("{0} ", matrix[i, j]);    // выводим его в консоль 
    }
    Console.WriteLine();
}

for (j = 0; j < m; j++)  // В цикле меняем первую строку матрицы с последней
{
    temp = matrix[0, j];
    matrix[0, j] = matrix[n - 1, j];
    matrix[n - 1, j] = temp;
}
Console.WriteLine("Матрица после замены строк:");
// Выводим полученную матрицу:

for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        Console.Write("{0} ", matrix[i, j]);
    }
    Console.WriteLine();
}
Console.Read();



