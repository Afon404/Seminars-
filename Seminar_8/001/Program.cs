// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

// Пример: Есть набор данных:

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// частотный массив может быть представлен так:

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза


///////////////////////////////////////////////////


int[] num = new int[8]{1, 9, 9, 0, 2, 8, 0, 9 };
Console.Write("Есть набор данных: " + String.Join(" ", num)+".");
Console.WriteLine();
Console.Write("Array of random numbers");
Console.WriteLine();
int[] count = new int[8];

int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
   
    Console.Write($" { array[i]}, ");
}

for (int i = 0; i < num.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
            if (array[j] == num[i])
                 count[i]++;
    }
}
    Console.WriteLine();
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($" Число {num[i]} было в массиве {count[i]} раз ");
}


/////////////////////////////////////////////////////