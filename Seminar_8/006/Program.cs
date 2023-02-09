
// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента



Console.WriteLine($"\nВведите размер массива :");
int Quantity = 3;
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine($"");

int[,,] array3D = new int[Quantity, rows, columns];
CreateArray(array3D);
WriteArray(array3D);



void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"rows({i+1}) columns({j+1}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"\ti({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
     //////////////////////////////////

    var separator = new string('-',  150); // Дублировать символ - 10 раз
    Console.WriteLine(separator);

    //////////////////////////////
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int Quantity = 0; Quantity < array3D.GetLength(0); Quantity++)
  {
    for (int rows = 0; rows < array3D.GetLength(1); rows++)
    {
      for (int columns = 0; columns < array3D.GetLength(2); columns++)
      {
        array3D[Quantity, rows, columns] = temp[count];
        count++;
      }
    }
  }
}

