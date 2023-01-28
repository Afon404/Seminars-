 
  //Показать числа Фибоначчи
 
 //   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597,

//ряд начинается с двух единиц, затем они складываются — получается двойка, 
//потом двойка вкладывается со второй единицей — получается тройка,
// тройка складывается с двойкой и т.д.
// int[] max = new int[] {int.Parse(Console.ReadLine())};

/////////////////////////////////////////////////////////////////////////


Console.Write("До какого числа показать числа Фибоначчи? :\t");
int number = int.Parse(Console.ReadLine()!);

int First = 1;
Console.Write("{0} ", First);
int Second = 1;
Console.Write("{0} ", Second);
int sum = 0;
while (number >= sum)
            {
                sum = First + Second;
                
                    Console.Write("{0} ", sum);
                    
                        First = Second;
                        Second = sum;                
                }
                Console.ReadLine();
