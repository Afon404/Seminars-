﻿

    //  Массивы :
    
    //  найти минимальный

// int[] myArray = {21, 44, 65, 7, 87, 9, 55};

// Console.WriteLine(myArray.Min());   

// Console.ReadLine();


///////////////////////////////////////////////////////////////////////////////
  //  Проверка на чётность: 


//   int[] myArray = {21, 44, 65, 7, 6, 87, 9, 56};

// Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());  //Sum это сложение нечётных чисел

// Console.ReadLine();


///////////////////////////////////////////////////////
      // ищем минимальное нечётное число:


//   int[] myArray = {21, 44, 65, 7, 6, 87, 9, 56};

// Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());  //Min ищем минимальное число

// Console.ReadLine();

///////////////////////////////////////////////////////////////

           //  Оставить только уникальные Элементы массива а повторяюшие не показывать:       

// int[] myArray = {21, 6, 44, 6, 44, 6, 44, 6, 65, 7, 6, 87, 9, 56, 6, };
// int[] result = myArray.Distinct().ToArray();
// Console.WriteLine("Заданный мною массив:\t" + String.Join(", ", myArray));
// Console.WriteLine("Только уникальные Элементы массива:\t" + String.Join(", ", result));
// Console.ReadLine();

//////////////////////////////////////////////////////

      //  Сортировка массива от мин до максимума:

// int[] myArray = {21, 6, 44, 6, 44, 6, 44, 6, 65, 7, 6, 87, 9, 56, 6 };
// Array.Sort(myArray);
// Console.WriteLine(String.Join(", ", myArray));

///////////////////////////////////////////////////////////

    //   Наити элемент в массиве который меньше или больше заданного мною числа 
    //         (Но которое есть в массиве):

// int[] myArray = {21, 6, 44, 6, 44, 6, 44, 6, 10, 65, 7, 6, 87, 9, 56, 6 };
// int result = Array.Find(myArray, i => i > 65);  //  Находит число первое которое есть в массива после 65:
// Console.WriteLine(result);
// Console.ReadLine();

//////////////////////////////////////////////////////

          //  Обратный порялок ищет с конца
    //   Наити элемент в массиве который меньше или больше заданного мною числа 
    //         (Но которое есть в массиве):

// int[] myArray = {21, 6, 44, 6, 44, 6, 44, 6, 10, 65, 7, 6, 87, 9, 56, 6 };
// int result = Array.FindLast(myArray, i => i < 65);  //  Находит минимальное число которое есть в массива перед 65:
// Console.WriteLine(result);
// Console.ReadLine();

//////////////////////////////////////////////////////

  //  Находим массив чисел которое меньше или больше заданного мною числа 
    //         (Но которое есть в массиве):

int[] myArray = {21, 6, 44, 6, 44, 6, 44, 6, 10, 65, 7, 6, 87, 9, 56, 6 };
//  Но тут переменную result должна быть соответствующего типа в моем случае массивом, так как она будет выводить группу чисел.
// int[] result = Array.FindAll(myArray, i => i < 50);  //  Находит групу чисел которое есть в массива перед 65:
// Console.WriteLine(String.Join(", ", result));
// Console.ReadLine();

/////////////////////////////////////////////////////////////////////////