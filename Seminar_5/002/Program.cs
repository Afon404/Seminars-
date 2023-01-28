 
  //Показать числа Фибоначчи
 
 //   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597,

//ряд начинается с двух единиц, затем они складываются — получается двойка, 
//потом двойка вкладывается со второй единицей — получается тройка,
// тройка складывается с двойкой и т.д.
// int[] max = new int[] {int.Parse(Console.ReadLine())};

 //   0, 1, 1, 2, 3, 5, 8, 13,
Console.Write("Введите диапазод до скольки: ");
int max = int.Parse(Console.ReadLine());
int countA = 0, countB = 0;

for (int i = 0; i < max.Length; i++)
{
   
 //   0, 1, 1, 2, 3, 5, 8, 13,
for (int j = 1; j < max.Length; j++)
{
    countB = j;
    countA = j + i;
}
}
System.Console.WriteLine($"Вывод {countA} {countB}");