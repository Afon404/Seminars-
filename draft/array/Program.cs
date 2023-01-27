   
       //   Создаём массив


// byte[] num = new byte[5]; //Создаем переменную new с 5 значениями
// num[0] = 5;    
// num[1] = 6;
// num[2] = 3;
// num[3] = 7;
// num[4] = 9;

// string[] word = new string[] {"Bob", "jon", "Aleks"};

// for(byte i = 0; i <= word.Length; i++)



// Console.WriteLine("Elements: " + word[i]);



////////////////////////////////////////////////////////////////////////

          //Случайный массив:

    
// short[] numbers = new short[10];
// short summa = 0;

// Random y = new Random();

// for(byte i = 0; i < numbers.Length; i++) {

// numbers[i] = Convert.ToInt16(y.Next(5, 15));

// Console.WriteLine("XXX: " + numbers[i]);

// summa += numbers[i];
// }

// Console.WriteLine("total amount : " + summa);


///////////////   Многомерный массив:

char[,] symbols = new char[2,3];
symbols[0, 0] = 'G';
Console.WriteLine(symbols[0, 0]);

int[,] num = {
{4, 6, 7},
{5, 7, 3},
{3, 3, 2},

};

num[1, 2] = 56;              

//////////////////////////////////////////