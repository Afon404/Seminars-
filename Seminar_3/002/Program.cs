


              ////    Подсчитать сумму цифр в числе.


Console.Clear();
System.Console.Write("Введите число: ");

// int number = new Random().Next(1, 100000); Можно изменить в Рандомное

int number = int.Parse(Console.ReadLine()!);
int sum_digit = 0;
System.Console.Write("Сумма цифр числа {0} равна:  ", number); //Чтобы не писать плюсы {0} это то что number.

while (number > 0)
{
    int digit = number % 10;
    sum_digit = sum_digit + digit;
    number = number / 10;
}

System.Console.WriteLine(sum_digit);
System.Console.WriteLine();






      
      
      
      
      
      
      ///////////////////////  Вариант коллеги:




// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int num = 0;
// int sum = 0;
// int count = 1;

// while (count <= number)
// {
//     num = number % (count * 10) / count;
//     sum += num;
//     count *= 10;
// }

// Console.WriteLine("Сумма цифр в числе " + number + " равна " + sum);