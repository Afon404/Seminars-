            
//             Рекурсия:
//    Показать натуральные числа от N до 1, N задано:

System.Console.Write("Введиче число N: ");
int n = int.Parse(Console.ReadLine()!);

void PrintArray(int n)
{
   if (n >= 0 )
    {
        Console.Write(n + " ");   //  2.
        PrintArray(n - 1);         // 1.   ( Поменять местами 1 и 2 в обратном порядке
    }
}
    
PrintArray(n);


/////////////// Не мой:

// Показать натуральные числа от N до 1, N задано

string NumbersRec(int n)
{
    if(n <= 9) return NumbersRec(n + 1) + $"{n}";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1));