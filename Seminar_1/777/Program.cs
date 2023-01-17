// Показать последнюю цифру трёхзначного числа

int n = 6667;
int lastNumber = n % 10;

Console.Write(lastNumber);


           //  Напишите программу, которая на вход принимает число и выдаёт, 
               //  является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
string firstString = Console.ReadLine();
int a = Convert.ToInt32(firstString);
  if (a%2 == 0){
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" чётное.");
  }
  if (a%2 > 0){
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" нечётное.");
  }









//  Напишите программу, которая принимает на вход три числа и 
//  выдаёт максимальное из этих чисел.

int a, b, c;
 Console.WriteLine("Введите первое число");

 a = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе число");

 b = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите третье число");

 c = Convert.ToInt32(Console.ReadLine());


int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max число = ");
Console.WriteLine(max);




 Console.WriteLine("Введите второе число");

 b = Convert.ToInt32(Console.ReadLine());


 if (a > b)
 
        {
 
            Console.Write("Наибольшее число : ");
            Console.WriteLine(a);
            Console.Write("Наименьшее число : ");
            Console.WriteLine(b);
 
        }
 
        else
 
        {
 
            Console.Write("Наибольшее число : ");
            Console.WriteLine(b);
            Console.Write("Наименьшее число : ");
            Console.WriteLine(a);
 
        }
 
        Console.ReadLine();











//        Вариант 1. Считаем через переменную

// int number1 = new Random().Next(1, 100);
// int result = number1 * number1;
// System.Console.WriteLine($"1 вариант. Квадрат числа {number1} = {result}");


//       Вариант 2. Сразу выводим результат 

// int number2 = new Random().Next(1, 100);
// System.Console.WriteLine($"2 вариант. Квадрат числа {number2} = {number2 * number2}");


//      Вариант 3. Ввод числа с клавиатуры

// System.Console.WriteLine("Введите число: ");
// string writeNumber = Console.ReadLine();
// int number3 = Convert.ToInt32(writeNumber);
// System.Console.WriteLine($"3 вариант. Квадрат числа {number3} = {number3 * number3}");