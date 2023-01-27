   Console.Clear();
Console.Write("Введите имя : ");

string  name = Console.ReadLine()!;

if (name.ToLower() == "юля")
{
   Console.WriteLine("Урааа это же Юля");
   Console.Write("Сколько у вас собак Юля: ");
    int Dogs = int.Parse(Console.ReadLine()!);
   if (Dogs == 3)
   {
   Console.WriteLine("Верно");
   Console.WriteLine("Ну а сколько у тебя кошек: ");
    int cat = int.Parse(Console.ReadLine()!);
    if (cat == 2)
    {
      Console.WriteLine("Похоже Вам полеженно вкусный торт)))"); 
      Console.Write("Хотите торт? " + " " + "Напишите на Английском,  Yes или No : ");
      Console.WriteLine();
      string[] cake = {"yes", "No "};
      string find = Console.ReadLine()!;   

///////////////////////////////////////////////////////////////////////////////////////
      // Хотим мы торт или нет

      string[] array = new string[] {"no",  "yes"};

int n = array.Length;

string   B = "+";

int index = 0;

while (index < n)
{
   if(find.ToLower() == "yes"){
    if (array[index] == find)
    {
        Console.WriteLine("А вот и торт : ");
        Console.WriteLine(B);
        break;
        
    }
    index++;
           
           /// Если не хотим торт
          
  }
else
{
Console.WriteLine("Не хотите торт как хотите ");
   break;
}
}

   ////////////////////////////////////////////////////////////////////////////////////////

    }
     else
       {
      Console.WriteLine("Какая же ты Юля что не знаешь сколько у тебя кошек");
       }
   }
   else
   {
   Console.WriteLine("Какая же ты Юля что не знаешь сколько у тебя собак");
   }
}

else
Console.WriteLine("Привет " + name);