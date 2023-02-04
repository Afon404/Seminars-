 
 /////////////////////////////////////////////////////////////////////////////////
 //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
//////////////////////////////////////////////////////////////////////////////////////


// Console.Write("Задайте количество строк двумерного массива:\t");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Задайте количество столбцов двумерного массива:\t");
// int n = int.Parse(Console.ReadLine());
// double[,] twoDimArray = new double[m, n];
// Random rnd = new Random();
// void PrintArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { Console.Write($"{matr[i, j]} ");}
//  Console.WriteLine();}}

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);


///////////////////////   Вариант 2:

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] array)
// {
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(random.Next(10) + random.NextDouble(), 3);
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк двумерного массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = new double[rows, columns];

// FillArray(array);
// PrintArray(array);


////////////////////////  Вариант 3:

// Console.WriteLine("Введите 2 числа, чтобы задать размерность массива");
// int n = int.Parse(Console.ReadLine());
// int m = int.Parse(Console.ReadLine());
// Random random = new Random();
// int [,] matrix = new int [n,m];
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++) 
//   {
//     matrix[i, j] = random.Next(-10, 10);
//   } 

// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     Console.Write($"\t| {matrix[i,j]} |\t");
//   }
//   Console.WriteLine(" ");

// }








////////////////////////////////////////////////////////////////
   //Задать двумерный массив следующим правилом: Aₘₙ = m+n
////////////////////////////////////////////////////////////////////

//    void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк двумерного массива m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива n: ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);


/////  Вариант 2:

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
        // Console.WriteLine($"{matrix[i, j] = i + j}");
        System.Console.Write(matrix[i, j]);
    }
        System.Console.WriteLine();
}






/////////////////////////////////////////////////////////////////
     //    В двумерном массиве заменить элементы, 
    //    у которых оба индекса чётные на их квадраты:
//////////////////////////////////////////////////////////////////





// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10);
//         }
//     }
// }

// void ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] *= array[i, j];
//         }
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк двумерного массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = new int[rows, columns];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeArray(array);
// PrintArray(array);



//////////////////////////   Вариант 2:



// void PrintArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} | ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {          
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {   
//         Random random = new Random();
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {                     
//             matr[i, j] = random.Next(10);                                   
//         }
//     }
// }

// void ChangeArray(double[,] matr)
// {          
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {           
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {                        
//             if (i % 2 == 0 && j % 2 == 0)
//             {                
//                 matr[i, j] = Math.Pow(matr[i, j], 2);
//             }                        
//         }
//     }
// }

// Console.Write("Введите количество строк двумерного массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] matrix = new double[rows, columns];

// Console.WriteLine("Исходный массив: ");
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine("Измененный массив: ");
// ChangeArray(matrix);
// PrintArray(matrix);







////////////////////////////////////////////////////////////////////////////////////
  // Написать программу, которая обменивает элементы первой строки и последней строки:
////////////////////////////////////////////////////////////////////////////////////



//   void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     Random random = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(10);
//         }
//     }
// }

// void ChangeStringsOfArray(int[,] array)
// {
//     int temp = 0;
//     int i = 0;

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//             temp = array[i, j];
//             array[i, j] = array[array.GetLength(0) - 1, j];
//             array[array.GetLength(0) - 1, j] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите количество строк двумерного массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов двумерного массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = new int[rows, columns];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeStringsOfArray(array);
// PrintArray(array);


// Написать программу, которая обменивает элементы первой строки и последней строки:
         //   вариант 2:




// Random  random = new Random();  // заполняем матрицу случайными числами
// int n = 4, m = 5;    
// int[,] matrix = new int[n, m];  // Создаём матрицу размерностью NxM
// int i, j, temp;             // Объявлем целочисленные переменные
// Console.WriteLine("Рандомная матрица:");
// for (i = 0; i < n; i++)
// {
//     for (j = 0; j < m; j++)
//     {
//         matrix[i, j] = random.Next(100);   //   каждому элементу матрицы  присваиваем случайное число
//         Console.Write("{0} ", matrix[i, j]);    // выводим его в консоль 
//     }
//     Console.WriteLine();
// }

// for (j = 0; j < m; j++)  // В цикле меняем первую строку матрицы с последней
// {
//     temp = matrix[0, j];
//     matrix[0, j] = matrix[n - 1, j];
//     matrix[n - 1, j] = temp;
// }
// Console.WriteLine("Матрица после замены строк:");
// // Выводим полученную матрицу:

// for (i = 0; i < n; i++)
// {
//     for (j = 0; j < m; j++)
//     {
//         Console.Write("{0} ", matrix[i, j]);
//     }
//     Console.WriteLine();
// }
// Console.Read();



///////////////////////////////////////////////////