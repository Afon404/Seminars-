//////    СТУПЕНЧАТЫЕ (ЗУБЧАТЫЕ , ступенчатые) МАССИВЫ:  


//  int[,] aaa = new int[2,3];     // прямоугольный  двухмкрный массив
 
 int[][] aaa2 = new int [3][];   //  Зубчатый массив
 aaa2[0] = new int[2];
 aaa2[1] = new int[4];
 aaa2[2] = new int[6];

// /////////   Заполнение  зубчатого массива случайными числами:


Random ddd = new Random();

for (int i = 0; i < aaa2.Length; i++)
{
    for (int j = 0; j < aaa2[i].Length; j++)
    {
        aaa2[i][j] = ddd.Next(100);
    }
}
// //////////////  Вывод массива сеткой: 


for (int i = 0; i < aaa2.Length; i++)
{
    for (int j = 0; j < aaa2[i].Length; j++)
    {
        Console.Write($"El:{aaa2[i][j]}\t ");
    }
    Console.WriteLine();
}






//////////////////////







