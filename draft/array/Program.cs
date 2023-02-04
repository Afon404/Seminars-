   
       //   Создаём массив


// byte[] num = new byte[5]; //Создаем переменную new с 5 значениями
// num[0] = 5;    
// num[1] = 6;
// num[2] = 3;
// num[3] = 7;
// num[4] = 9;

// string[] word = new string[] {"Bob", "jon", "Aleks"};

// for(byte i = 0; i <= word.Length; i++)



// Console.WriteLine("Elements: " + word[i]);



////////////////////////////////////////////////////////////////////////

          //Случайный массив:

    
// short[] numbers = new short[10];
// short summa = 0;

// Random y = new Random();

// for(byte i = 0; i < numbers.Length; i++) {

// numbers[i] = Convert.ToInt16(y.Next(5, 15));

// Console.WriteLine("XXX: " + numbers[i]);

// summa += numbers[i];
// }

// Console.WriteLine("total amount : " + summa);


///////////////   Многомерный массив:

// char[,] symbols = new char[2,3];
// symbols[0, 0] = 'G';
// Console.WriteLine(symbols[0, 0]);

// int   [,] num = {
// {4, 6, 7},
// {5, 7, 3},
// {3, 3, 2},

// };

// num[1, 2] = 56;              

////////////////////////////////////////////////////////////////////////
////////////////////  ЧТО ТАКОЕ МАССИВЫ | ОДНОМЕРНЫЙ МАССИВ //////////////
///////////////////////////////////////////////////////////////////////////

// int[] arrayA;
// arrayA = new int[5];
// arrayA[4] = 88;
// Console.WriteLine(arrayA[4]);


/////////////////////////////////////////////////////////////

// int[] arrayA;
// arrayA = new int[5];
// arrayA[4] = 88;       //   Вывод массива
// int a = arrayA[4];
// Console.WriteLine(a);

////////////  ИНИЦИАЛИЗАЦИЯ МАССИВА | СПОСОБЫ :  # 25

// int[] arrayA = new int[] {1, 2, 3, 4};   // Вариант 1

// int[] arrayA = new[] {1, 2, 3, 4};           // Вариант 2

//  int[] arrayA = {1, 2, 3, 4};             // Вариант 3

// Console.WriteLine(arrayA[2]);

////////////////   ВЫВОД МАССИВА | ПЕРЕБОР МАССИВА | МАССИВЫ И ЦИКЛ:


// int[] arrayA = {33, 55, 66, 67};

// for (int i = 0; i < arrayA.Length; i++)
// {
//        Console.WriteLine(arrayA[i]);  //   вывод всего массива
// }

/////////////////////////////////////////////////////
                       //   вывод всего массива 2

// int[] arrayA = {33, 55, 66, 67};

// for (int i = 0; i < arrayA.Length; i++)
// {
// Console.WriteLine("вывод " + String.Join(" ", arrayA[i]));  //   вывод всего массива
// }

//////////////////////////// Заполнить массиа с клавиатуры :



// Console.Write("Введите колличество элементов массива:\t");
// int elementsCaunt = int.Parse(Console.ReadLine()!);
// int[] myArray = new int [elementsCaunt];

// for (int i = 0; i < myArray.Length; i++)
// {
//        Console.Write($"\nВведите элемет массива под индексом {i}:\t");
//        myArray[i] = int.Parse(Console.ReadLine()!);

// }


// Console.WriteLine("Вывод массива: ");

// for (int i = 0; i < myArray.Length; i++)
// {
//        Console.WriteLine(myArray[i]);
// }





///////////////////////////   Вывести массив вобратном порядке:



// int[] arrayA = new int[] {22, 33, 44, 55, 66};

// for (int i = arrayA.Length - 1; i >= 0; i--)
// {
//        Console.WriteLine(arrayA[i]);
// }





//////////////////////  Найти сумму чётных чисел в массиве: 

// // считаем чётные:

// int[] arrayA = {88, 2, 5, 7, 10};
// int sum = 0;
// int odd = 0;
// for (int i = 0; i < arrayA.Length; i++)
// {
       
//      if(arrayA[i] % 2 == 0)
// {
//        // sum = sum + arrayA[i];
//        sum += arrayA[i];           //  То же самое
// }


// }

// ////// Считаем нечётные:

// for (int i = 0; i < arrayA.Length; i++)
// {
       
//      if(arrayA[i] % 2 != 0)
// {
//        // sum = sum + arrayA[i];
//        odd += arrayA[i];           //  То же самое
// }


// }

//        Console.WriteLine($"Sum array = {sum}");
//        Console.WriteLine($"Sum array odd = {odd}");







///////////////////////  Найти наименьшее число в массиве:

int[] arrayA = new int[] {22, 44, 55, 2, 77,};
int min = arrayA[0];
for (int i = 1; i < arrayA.Length; i++)
{
       if(arrayA[i] < min)      //  Можно поменять на Max
       {
              min = arrayA[i];
       }
}
Console.WriteLine($"наиментшее число в массиве: {min} ");









//////////////////////////////////////////
