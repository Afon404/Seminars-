     //Написать программу копирования массива.




 

      //   int[] arr = { 5, 4, 7, 2, 9 };
 
      //   int[] copy = new int[arr.Length];
      //   arr.CopyTo(copy, 0);
 
      //   Console.WriteLine(String.Join(", ", copy));        // 5, 4, 7, 2, 9
 




 /////////////////// //   извлекаем из одного массива в другой:


//   int[] numbers = {1,2,3,4,5,6,7,8,9,};

//   int[] Extracted = numbers[3..8];  // Если хотим извлечь от первого числа то его можно не указываать[..8]

// Console.WriteLine(String.Join(", ", numbers));
// Console.WriteLine(String.Join(", ", Extracted));

//////////////////////////////  Вариант 2:



class Program
{
    static void Main()
    {
      // Мы создаем новый массив int с 5 элементами. присваиваем элементам некоторые целые числа:
                                                     
        int[] source = new int[5];
        source[0] = 1;
        source[1] = 2;
        source[2] = 3;
        source[3] = 4;
        source[4] = 5;
        Console.Write("Заданный массив:\t" + String.Join(", ", source));
        //  Далее мы выделяем пустой массив из 5 целых чисел. Все они равны 0 при создании массива:

        int[] target = new int[5];    
        
        // вызываем Copy с 3 аргументами — исходным массивом, целевым массивом и длиной, которую мы хотим скопировать:
        Array.Copy(source, target, 5);
        
        // Целевой массив записывается в консоль. Он имеет то же содержимое, что и исходный массив:
        foreach (int value in target)
        {
            // System.Console.WriteLine();
            Console.WriteLine("\nСкопированный массив:\t" + value);
        }
        
    }
}