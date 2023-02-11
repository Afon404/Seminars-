

                    
    // //   Рекурсия:   Найти сумму элементов от M до N, N и M заданы


// Найти сумму элементов от M до N, N и M заданы

void PrintElements(int m, int n)
{
    if (n < m) Console.Write($"");
    else
    {
        PrintElements(m, n - 1);
        Console.Write($"{n} ");
    }
}

int SumElements(int m, int n)
{
    if (n == m) return n;
    else return n + SumElements(m, n - 1);
}

int n = InputNumbers("Введите число M: ");
int m = InputNumbers("Введите число N: ");

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

System.Console.WriteLine($"Последовательность чисел от {m} до {n}: ");
PrintElements(m, n);
Console.WriteLine();  
System.Console.Write($"Сумма чисел от {m} до {n} равна {SumElements(m, n)}");
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

///////////////////////////////////
