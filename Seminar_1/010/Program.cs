                // Удалить вторую цифру трёхзначного числа

Console.Clear();
System.Console.WriteLine("Вуаля, Магия)))");

int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

System.Console.WriteLine();
System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
System.Console.WriteLine();











// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите позицию");
// int s = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// while (s > 1) {
//      m *= 10;
//      s--;
// }
// int t = (x % m) + (x / (m * 10)) * m;
// Console.WriteLine(t);