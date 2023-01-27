
         // Цикл For:


// for (double i = 200; i > 10; i /= 2)   //Можно использовать float
// {
//     Console.WriteLine("Element: {0}", i);
// }


     // Цикл While:

// int i = 200;
// while (i > 10)
// {
//     System.Console.WriteLine("Element: {0}", i);
//     i /= 2;
// }    

///////////////////  Это условие будет выполняться пока не напишем toyota

// bool isHasCar = true;
// while (isHasCar)
// {
//     Console.Write("Введите марку японского авто: ");
//     string toyota = Console.ReadLine();
//     if(toyota == "toyota")
//     {
//         isHasCar = false;
//     }
// }    


              //  Цикл   do  проверяет только 1 раз но если бы условие было верным он бы выполнял пока не станет неверным


// int i = 100;
// do
// {
//     Console.WriteLine("Element: " + i);
// } while (i < 10);


////////////////////////////


// for (int i = 0; i < 10; i++)
// {
//     // if(i > 5)
//     // break;
// if(i % 2 == 0) //определяем какие числа являються четными// Если остаток при делении будет равен нулю
// continue;    // Это значение будет пропускать условие(В нашем случае чётные числа)

//     Console.WriteLine("Element:" + i);
// }


///////////////////   ЦИКЛ WHILE


// int count = 0;
// while(count < 10){
// count++;
// Console.WriteLine(count);
// }
