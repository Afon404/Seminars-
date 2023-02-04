
//  создаём двухмерный массив: 

// int[,] my = new int[2,5];
// my[0,2] = 99;
// System.Console.WriteLine(my[0,2]);


////////////////////////////////   то же самое: 


// int[,] my;
// my = new int[3,5];
// my[0,2] = 99;
// System.Console.WriteLine(my[0,2]);

//////////////////////////////////////////////////////////

// int[,] my = new int[3,5]
// {
// {1,2,3,4,5},
// {1,2,3,4,5},
// {1,2,3,44,5}

// };
// Console.WriteLine(String.Join(", ", my[2,3]));

/////////////  Вывод двухмерного массива: 

// int[,] aaa = new int[,]
// {
// {1,2,3,4,5},
// {1,2,3,4,5},
// {1,2,3,44,5}  
// };

// foreach (var bbb in aaa)
// {
//     System.Console.WriteLine(bbb);
// }


/////////////////////   Вывод массива сеткой: 

// int[,] aaa = new int[,]
// {
// {1,2,3,4,5},
// {1,2,3,4,5},
// {1,2,3,44,5}
// };

// int height = aaa.GetLength(0);
// int width = aaa.GetLength(1);
// aaa[0,4] = 99;
// aaa[2,1] = 87;
// for (int i = 0; i < height; i++)
// {
//     for (int j = 0; j < width; j++)
//     {
//         Console.Write(aaa[ i, j] + ",\t " );
//     }
//     Console.WriteLine();
// }



////////////////  Ппросто мой массив:

// int[,] aaa = new int[10, 6];
// int height = aaa.GetLength(0);
// int width = aaa.GetLength(1);


// for (int x = 0; x < height; x++)
// {
//     for (int y = 0; y < width; y++)
//     {
//         Console.Write(aaa[x, y] + ",\t");
//     }
//     Console.WriteLine();
// }


//////////////////////   То же самое , вариант 2: 
              
                 //   Но без:    // int height = aaa.GetLength(0);
                                // int width = aaa.GetLength(1);

              //  Но с использованием    "  aaa.GetLength  "

// int[,] aaa = new int[10, 6];



// for (int x = 0; x < aaa.GetLength(0); x++)
// {
//     for (int y = 0; y < aaa.GetLength(1); y++)
//     {
//         Console.Write(aaa[x, y] + ",\t");
//     }
//     Console.WriteLine();
// }



/////////  Заполнение двухмерного массива случайнами числами:  



// int[,] aaa = new int[10, 6];
// Random bam = new Random();

// /////////   Заполнение случайными числами:

// for (int i = 0; i < aaa.GetLength(0); i++)
// {
//     for (int j = 0; j < aaa.GetLength(1); j++)
//     {
//         aaa[i, j] = bam.Next();
        
//     }
// }
// //////////////  Вывод массива сеткой: 

// for (int x = 0; x < aaa.GetLength(0); x++)
// {
//     for (int y = 0; y < aaa.GetLength(1); y++)
//     {
//         Console.Write(aaa[x, y] + ",\t");
//     }
//     Console.WriteLine();
// }



//////////     ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА С КЛАВИАТУРЫ числами:



// int[,] aaa = new int[2, 3];
// /////////   Заполнение 

// for (int i = 0; i < aaa.GetLength(0); i++)
// {
//     for (int j = 0; j < aaa.GetLength(1); j++)
//     {
//         Console.WriteLine($"Ряд: {i}, Столб: {j}");
//         aaa[i, j] = int.Parse(Console.ReadLine()!);
//     }
// }
//     System.Console.WriteLine();
//     System.Console.WriteLine("ваш массив: ");
// //////////////  Вывод массива сеткой: 

// for (int x = 0; x < aaa.GetLength(0); x++)
// {
//     for (int y = 0; y < aaa.GetLength(1); y++)
//     {
//         Console.Write("El : " + aaa[x, y] + ",\t");
//     }
//     Console.WriteLine();
// }


//////////////

//////////     ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА С КЛАВИАТУРЫ :  string



// string[,] aaa = new string[2, 3];
/////////   Заполнение : 

// for (int i = 0; i < aaa.GetLength(0); i++)
// {
//     for (int j = 0; j < aaa.GetLength(1); j++)
//     {
//         Console.WriteLine($"Ряд: {i}, Столб: {j}");
//         aaa[i, j] = (Console.ReadLine()!);
//     }
// }
//     System.Console.WriteLine();
//     System.Console.WriteLine("ваш массив: ");

// //////////////  Вывод массива сеткой: 

// for (int x = 0; x < aaa.GetLength(0); x++)
// {
//     for (int y = 0; y < aaa.GetLength(1); y++)
//     {
//         Console.Write("El : " + aaa[x, y] + ",\t");
//     }
//     Console.WriteLine();
// }


/////// Конец:

