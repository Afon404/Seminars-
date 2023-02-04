
//   ТРЁХМЕРНЫЕ МАССИВЫ | МНОГОМЕРНЫЕ МАССИВЫ ЛЮБОЙ МЕРНОСТИ:


// int[,,] aaa = new int[4,3,5];

// aaa[0, 2, 3] = 55;

// Console.WriteLine(aaa[0, 2, 3]);

/////////////

// int[,,] aaa = 
// {
//     {
//         {2,3,5},
//         {5,7,44}
//     },

//     {
//         {4,66,4},
//         {4,22,1}
//     },

//     {
//         {44,65,37},
//         {78,90,9}
//     }
// };

/////////////////////////////////////

             //       МНОГОМЕРНЫЕ МАССИВЫ: 

// Random ddd = new Random(); 
// int[,,] aaa = new int[5, 3, 5];

// for (int i = 0; i < aaa.GetLength(0); i++)
// {
//     for (int j = 0; j < aaa.GetLength(1); j++)
//     {
//         for (int k = 0; k < aaa.GetLength(2); k++)
//         {
//             aaa[i, j, k] = ddd.Next(100);
//         }
//     }
// }

// ///////////////////////////////  Счётчик:

// for (int i = 0; i < aaa.GetLength(0); i++)

// {
//     Console.WriteLine($"Page №: {i+1}");
//     for (int j = 0; j < aaa.GetLength(1); j++)
//     {
//         for (int k = 0; k < aaa.GetLength(2); k++)
           
//         {   
//          Console.Write($" \t|{aaa[i,j, k]}|\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("============================================================================");
// }
// Console.ReadLine();



             //       МНОГОМЕРНЫЕ  ЗУБЧАТЫЕ МАССИВЫ: 

Random ddd = new Random(); 

int[][][] aaa = new int[ddd.Next(6, 6)][][];   //  Столб

for (int i = 0; i < aaa.Length; i++)
{
    aaa[i] = new int[ddd.Next(5, 5)][];   ///  Строка

    for (int j = 0; j < aaa[i].Length; j++)
    {
        aaa[i][j] = new int[ddd.Next(10, 10)];   //Позиция
        
        for (int k = 0; k < aaa[i][j].Length; k++)
        {
            aaa[i] [j] [k] = ddd.Next(100);   // Числа
        }
    }
}

///////////////////////////////  Счётчик:

for (int i = 0; i < aaa.Length; i++)

{
    Console.WriteLine($"Page №: {i+1}");

    for (int j = 0; j < aaa[i].Length; j++)
           
        {   
         for (int k = 0; k < aaa[i][j].Length; k++)
         {
            Console.Write($"{aaa[i][j][k]}\t");
         }
            Console.WriteLine();
        }
        
        Console.WriteLine("========================================================");
    }
 

Console.ReadLine();


////////////////////////////////////////////////////////////