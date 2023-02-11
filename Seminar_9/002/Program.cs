
                      
   /// Рекурсия:  Показать натуральные числа от M до N, N и M заданы:

///////////////////////  Вариант 1:

// int n = InputNumbers("Введите число M: ");
// int m = InputNumbers("Введите число N: ");

// void NaturalNumbers(int m, int n)
// {
//     if (n < m) Console.Write($"");
//     else
//     {
//         NaturalNumbers(m, n - 1);
//         Console.Write($"{n} ");
//     }
// }

// if (m > 0 && n > 0)
// {
//     if (m > n)
//     {
//         int temp = m;
//         m = n;
//         n = temp;
//     }
//     System.Console.WriteLine($"Натуральные числа от {m} до {n}:");
//     NaturalNumbers(m, n);
// }
// else Console.WriteLine("Error");

// /////////////////////////////

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }




/////////////// Вариант 2:  ///////////// Чила введены: от M до N, а показанны: от N до M.

int n = InputNumbers("Введите число M: ");
int m = InputNumbers("Введите число N: ");
string NumbersRec(int n,int  m)
{
    if(n <= m) return NumbersRec(n + 1, m) + $"{n}";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(n,m));
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}