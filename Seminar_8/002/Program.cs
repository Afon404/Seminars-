// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных 2.

// Если набор данных - таблица

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// на выходе ожидаем получить

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



/////////////////////////////////////


int[] num = new int[9]{1, 2, 3, 4, 6, 1, 2, 1, 6 };   

int[] count = new int[9];

int[,] arr = NewArray(3,5,0,10);

PrintArray(arr);

for (int i = 0; i < num.Length; i++)
{
    for (int s = 0; s < arr.GetLength(0); s++)
    {
        for (int r = 0; r < arr.GetLength(1); r++)
        {
            if (arr[s,r] == num[i])
                    count[i]++;
        }
    }
}

for (int i = 0; i < num.Length; i++)
{
    System.Console.WriteLine($" Число {num[i]} было в массиве {count[i]} раз ");
}

///////////////////


   void PrintArray(int[,] arr)
        {
    if (arr is null)
    {
        throw new ArgumentNullException(nameof(arr));
    }

    for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }


///////////////////////////////////
       

        int[,] NewArray(int column, int row, int min, int max)
        {
            int[,] arr = new int[column, row];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(min, max);
                }
            return arr;
        }
        

/////////////////////////////////////////////////////ggg
