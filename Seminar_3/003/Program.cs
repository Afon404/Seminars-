




     ////   Написать программу вычисления произведения чисел от 1 до N


Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите число:   ");  //То же самое что слева  // string writeN = Console.ReadLine();
int N = int.Parse(Console.ReadLine()!);                             // int N = Convert.ToInt32(writeN);


int GetNumbers(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbers(N)}");
System.Console.WriteLine();




   ////  Вариант 2

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// int number = 1;
// int result = 1; 

// while (number <= N)
// {
//     result *= number;  // Result -  Принимает значения умножения
//     number++;          // number + 1
// }

// Console.WriteLine("Произведение числе от 1 до {0} равно {1}", N,  result);