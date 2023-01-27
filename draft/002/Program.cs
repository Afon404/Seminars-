
/////////              Задача деления с остатком:



// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите чисо на которое будем делить: ");
// int b = int.Parse(Console.ReadLine());
// int c = a % b;
// int x =  a / b ;

// System.Console.WriteLine($"Результат деления равен: {x}");
// System.Console.WriteLine($"Остаток от деления равен: {c}");




/////////////////////////////////////////////////////////////////////////

    // напишите прогграмму , вычисляющую среднее фрифметическое двух чисел:


// double a, b, z;
// Console.Write("Введите первое число: ");
// a = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// b = double.Parse(Console.ReadLine());
// z = (a + b) / 2;
// Console.WriteLine($"среднее фрифметическое этих двух чисел равно: {z}");



/////////////  Введите 3 числа и выведите на экран значение суммы и произведения этих чисел:

// Console.Write("Введите первое число: ");
// int one = int.Parse(Console.ReadLine());

// Console.Write("Введите второе чисдо: ");
// int two = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int three = int.Parse(Console.ReadLine());

// int result = one +  two+ three;
// int sum = one * two * three;
// Console.WriteLine($"значение суммы: {result}");
// Console.WriteLine($"произведения этих чисел: {sum}");

////////////////////////////////////////////////////////////////////////////////////
/////  напишите простой конверт валют


// double sum, dollars, result;  // можно сразу задать переменную
// Console.Write("Введите сколько  вы хотите купить долларов: ");
// sum = double.Parse(Console.ReadLine());    //// 100 $
// dollars = 74.24;
// result = dollars * sum;
// Console.WriteLine($"{sum}$ будут стоить {result} рублей");



//////  Количество четных и нечетных целых чисел в том диапазоне которые укажет пользователь


// int evenNumbers = 0;
// int oddNumbers = 0;
// int oddNumbersSum = 0;
// int evenNumbersSum = 0;
// Console.Write("Введите минимальное число диапазона: ");
// int currentValueUsers = int.Parse(Console.ReadLine()!);
// Console.Write("Введите максимальное число диапазона: ");
// int LimitUses = int.Parse(Console.ReadLine()!);

// while (currentValueUsers <= LimitUses)
// {
//     if (currentValueUsers % 2 == 0)
//     {
//         evenNumbers++;
//         evenNumbersSum += currentValueUsers;
//     }
//     else
//     {
//         oddNumbers++;
//         oddNumbersSum = oddNumbersSum + currentValueUsers;
//     }

//     currentValueUsers++;

// }
// Console.WriteLine($"Количество чётных чисел {evenNumbers}");
// Console.WriteLine($"Сумма чётных чисел {evenNumbersSum}");
// Console.WriteLine($"Количество нечётных чисел {oddNumbers}");
// Console.WriteLine($"Сумма нечётных чисел {oddNumbersSum}");
// Console.ReadLine();






// // // // // // // // // /////////////////////////////////////////////// // // // // // // // // // 

// Console.WriteLine("Your array: " + String.Join("; ", arrayNum[3] ));




/////////////////////////////////////  Цикл  for:



// for(int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

///////////  ЦИКЛ FOR | В ОБРАТНОМ ПОРЯДКЕ | НЕСКОЛЬКО ПЕРЕМЕННЫХ | НЕСКОЛЬКО УСЛОВИЙ |

// for(;;)                    // даже если нету условия(цикла)всё равно должна быть разделена на 3 части ";"
// {
//     Console.WriteLine("Привет мир! ");
//     System.Threading.Thread.Sleep(300);   // скорость вывода сообщения на консоль
// }

/////////////////////////////


// // int i = 0;

// // for (; i < 3; i++)
// // {
// //      Console.WriteLine($"Для for-1 {i}");
// // }
// // Console.WriteLine("/////////////////////////////////////////////////");
// // for (; i < 8; i++)
// // {
// //     Console.WriteLine($"Для for-2 {i}");
// // }


// //////////////   Обратный порядок


// for (int i = 5, j = 0; i >= 0; i--, j++)
// {
//     Console.WriteLine($"Обратный отсчёт :{i}");
//     Console.WriteLine($"отсчёт Вперёд :{j}");
// }


//////////////////////////////////////////////////////////////////



// for (int i = 1; i <= 5; i++)
// {   Console.WriteLine($"У вас 5 попыток");
//     Console.Write("Как звали кота в простаквашино: ");
//     Console.WriteLine($"Попытка № {i}");
//     String Question = Console.ReadLine()!;
//     if (Question.ToLower() == "матроскин")
//     {
//         Console.WriteLine("Урааааа ))) Правильно");
//         break;
//     }
// }

//////////////////////////////////////  Continio

// for (int i = 1; i < 10; i++)
// {
//     if (i == 2){continue;}
//     if (i == 3){continue;}
//     if (i == 4){continue;}
//     if (i == 5)
//     {
//         continue;

//     }
//     Console.WriteLine(i);
// }


//////////////////////     Вложенные циклы:


// for (int i = 1; i <= 3; i++)
// {
//         Console.WriteLine($"Цикл 1 итерация №: {i}");
//     for (int j = 1; j <= 5; j++)
//     {
//         Console.WriteLine($"\tЦикл 2 итерация №: {j}");
//         for (int k = 1; k <= 2; k++)
//         {
//           Console.WriteLine($"\t\tЦикл 3 итерация №: {k}");  
//         }
//     }
//     Console.ReadLine();
// }






