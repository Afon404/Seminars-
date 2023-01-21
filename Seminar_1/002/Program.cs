      // По двум заданным числам проверять является ли первое квадратом второго. 

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (Math.Sqrt(number1) == number2)
{
    Console.Write(" {0} является квадратом {1}", number1, number2);
}
else
{
    Console.Write("Условие не верно.");
}


          //   Вариант 2:


// Console.WriteLine("По двум заданным числам проверяем, является ли первое квадратом второго");
// Console.Write("Введите число 1: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 * number1 == number2)
// {
//     Console.Write("Число 1 является квадратом числа 2.");
// }
// else
// {
//     Console.Write("Число 1 не является квадратом числа 2.");
// }