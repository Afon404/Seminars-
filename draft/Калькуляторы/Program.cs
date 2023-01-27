             
             //   ОПЕРАЦИИ СРАВНЕНИЯ | ОПЕРАТОРЫ ОТНОШЕНИЯ 


// int a = 4, b = 5;
// bool result = a != b;
// Console.WriteLine(result);




//////////////////////////////////////////////////////////////////


// bool ill = true;

// if(ill)
// {
// Console.WriteLine("Персонаж болен.");
// }
// else
// {
//     Console.WriteLine("Персонаж не болен");
// }



////////////////////////////////////////////////////

// Console.WriteLine("Угадайте число от 1 до 5");
// Console.WriteLine();
// Console.Write("Введите число: ");
// int a, i;
// i = new Random().Next(1, 5);
// a = int.Parse(Console.ReadLine());

// if(a == i)
// {
// Console.WriteLine("Вы угадали число ");
// }
// else
// {
// Console.WriteLine("Вы не угадали число ");
// }



//////Напишите программу, проверяющую число, введенное с клавиатуры на чётность



// Console.Write("Введите число, а я проверю четное оно или нет: ");
// string text = "Введённое вами число ";
// int Number = int.Parse(Console.ReadLine());

// if(Number % 2 == 0)
// {
//     Console.WriteLine($"{text} {Number} четное ");
// }
// else
// {
//     Console.WriteLine($"{text} {Number} не чётное ");
// }


////////////////////////////////////////////////////

// bool ill = true;
// if(!ill)
// {
//     Console.WriteLine("Перрсонаж больен");
// }


/////////////////////////////////////////////////////////


// int fanSpeen = 3000;
// int temperetura = 50;
// // int isHighTemperature = 80;
// bool hasNoCooling = fanSpeen <= 0, isHighTemperature = temperetura >=80;
// if(isHighTemperature | hasNoCooling)
// {
//     Console.WriteLine("Угроза повреждения процессора");
// }



/////////////////////   оператор switch

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine());

// switch (a)
// {
//     case 1:
//         Console.WriteLine("Вы ввели число 1");
//         break;
//     case 2:
//         Console.WriteLine("Вы ввели число 2");
//         break;
//     default:
//         Console.WriteLine("Мне не известны числа более 2");
//     break;
// }


////////////////////////////////////////////////////

// ConsoleKey consoleKey = Console.ReadKey().Key;

// switch (consoleKey)
// {
//     case consoleKey.a:
//         Console.WriteLine("Вы нажали: ");
//     break;
// }


/////////////////////////////   Калькулятор: через switch

// double firstValue, secondValue;
// string action;

// Console.Write("введите первое число: ");
// firstValue = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// secondValue = double.Parse(Console.ReadLine());

// Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
// action = Console.ReadLine();

// switch (action)
// {
//     case "+":
//         Console.WriteLine(firstValue + secondValue);
//     break;
//     case "-":
//         Console.WriteLine(firstValue - secondValue);
//     break;
//     case "*":
//         Console.WriteLine(firstValue * secondValue);
//     break;
//     case "/":
//     if(secondValue == 0)
//         {
//             Console.WriteLine("Деление на ноль невозможно");
//         }
//     else
//     {
//             Console.WriteLine(firstValue / secondValue);
//     }
//     break;
//     default:
//         Console.WriteLine("Error");
//     break;
// }




///////////////////////////////////// Калькулятор через if else



// while (true){
// Console.Clear();
// double firstValue, secondValue;
// string action;

// try                          //  этот цикл выводит ошибку
// {
// Console.Write("введите первое число: ");
// firstValue = double.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// secondValue = double.Parse(Console.ReadLine());
// }
// catch (Exception)
// {
    
//     Console.WriteLine("Это же калькулятор");
//     Console.WriteLine("Введите числа а не буквы");
//     Console.ReadLine();     //Enter
//     continue;       
// }


// // Console.Write("введите первое число: ");
// // firstValue = double.Parse(Console.ReadLine());
// // Console.Write("Введите второе число: ");
// // secondValue = double.Parse(Console.ReadLine());




// Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
// action = Console.ReadLine();

//     if (action == "+")
// {
//     Console.WriteLine(firstValue + secondValue);
// }
// else if(action == "-")
// {
//     Console.WriteLine(firstValue - secondValue);
// }
// else if(action == "*")
// {
//     Console.WriteLine(firstValue * secondValue);
// }


// else if( secondValue == 0)
// {
//     Console.WriteLine("Деление на ноль невозможно");
// }
// else  if(action == "/" )
// {
//     Console.WriteLine(firstValue / secondValue);
// }
 


    

// else
// {
    
//     Console.WriteLine("Eror");
    
// }
// Console.ReadLine();    // Стоит перед концом цикла wile чтобы  только при нажатии на enter очищалась 
// }




/////////////////////////////////////////////////////