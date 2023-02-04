
//    Получаем число с конца:

// int[] numbers = {1,2,3,4,5,6,7,8,9,};

// Console.WriteLine(numbers[^2] );


  //   извлекаем из одного массива в другой:


//   int[] numbers = {1,2,3,4,5,6,7,8,9,};

//   int[] Extracted = numbers[3..8];  // Если хотим извлечь от первого числа то его можно не указываать[..8]

// Console.WriteLine(String.Join(", ", numbers));
// Console.WriteLine(String.Join(", ", Extracted));


////////////////////////   2

// int[] numbers = {1,2,3,4,5,6,7,8,9,};
// Index find = 3;   //  значение будет False потому что мы взялм элемент не с конца: ^3 тогда будет true

// Console.WriteLine(numbers[find]);
// Console.WriteLine();
// Console.WriteLine($"value {find.Value} isFromend {find.IsFromEnd}");


///// ////////////////  3   извлекаем массив который нужен: 

// int[] numbers = {1,2,3,4,5,6,7,8,9,};

// System.Console.WriteLine(String.Join(", ", numbers[1..6]));


///// ////////////////  3   извлекаем массив String который нужен: 

// String str = "Hello world!";

// System.Console.WriteLine(str[0..6]);


//////////////////////////////////////////////////////////////////////////