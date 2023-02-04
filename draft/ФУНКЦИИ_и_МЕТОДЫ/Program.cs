
     //   ФУНКЦИИ И МЕТОДЫ: 

// class Program
// {  
// static  int Sum(int a, int b)
// {
//      int result = a * b;
//      return result;

// }


// static void Main(string[] args)
// {
//      int a, b, c;
//      a = int.Parse(Console.ReadLine()!);
//      b = int.Parse(Console.ReadLine()!);
     
     

//      c = Sum(a, b);
//      Console.WriteLine(c);
//      Console.WriteLine("==============================");
// }
// }

///////////////////////  Д.З
//  Написать метод короый выводит на экран строку:
// Символы из которых состоит строка и их колличкство вводиться пользователем.

// class Program
// {
     

// static void PrintLine(string symbol, uint symbolsCount)
// {
//      for (int i = 0; i <symbolsCount; i++)
//      {
//           Console.WriteLine(symbol);
//      }
// }

// static void Main(string[] args)
// {
//      //Вводим символ:
//      Console.Write("Введите символ: ");
//      string symbol = Console.ReadLine()!;
//      //Вводим количество символов:
//      Console.Write("Введите колличество символов: ");
//      uint symbolsCount = uint.Parse(Console.ReadLine()!);


//      PrintLine(symbol, symbolsCount);
// }

// }
//////////////////////  Д.З_2:

// Написать метод для поиска индекса элемента массива (тип элементов в массиве int),
// Метод должен вернуть индекс первого найденного элемента (если лн будет найден).

// class Program
// {
//      static int IndexOf(int [] array, int value)
//      {
//           for (int i = 0; i < array.Length; i++)
//           {
//                if (array[i] == value)
//                {
//                    return i; 
//                }
//           }
//           return -1;
//      }

//      static int[] GetRamdomArray(uint length, int minValue, int maxValue)
//      {
//           int[] myArray = new int[length];
//           Random random = new Random();

//           for (int i = 0; i < myArray.Length; i++)
//           {
//                myArray[i] = random.Next(minValue, maxValue);
//           }
//           return myArray;

//      }

//      static void Main(string[] args)
//      {
//           int[] myArray = GetRamdomArray(10, -20, 10);
//           int result = IndexOf(myArray, 9);
//           Console.WriteLine(result);
//      }


// }


///////////////////   Имя:


// class Program
// {
//     static void nameMetod(string nameBob)
//     {
//         Console.WriteLine("Привет" + nameBob );
//     }

//     static void Main(string[] args)
//     {
//         nameMetod(" Fediya");
//     }


// }