

                //      Рекурсия:
       //  Написать программу вычисления функции Аккермана:


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}



/////////////////////////////////////////////////////////////////

// int Akkerman(int n, int m)
// {
//     if (n == 0) return m + 1;
//     else if (n != 0 && m == 0) return Akkerman(n - 1, 1);
//     else return Akkerman(n - 1, Akkerman(n, m - 1));
// }

// int n = 10;
// int m = 3;

// Console.WriteLine($"Функция Аккермана A({n},{m}):");
// if (n >= 0 && m >= 0)
// {
//     for (int i = 0; i <= n; i++)
//     {
//         for (int j = 0; j <= m; j++)
//         {
//             Console.Write($"{Akkerman(j, i)} ");
//         }
//         Console.WriteLine();
//     }
// }
// else Console.WriteLine("Числа должны быть неотрицательные!");


////////////////////////////////////////////////////////////


