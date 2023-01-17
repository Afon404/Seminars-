              //  По заданному номеру дня недели вывести его название

string[] days = {"Понедельник", "Вторник", "Среда",
               "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine("Введите число от 1 до 7: ");

int number_user = Convert.ToInt32(Console.ReadLine()) - 1;
if (number_user < 7)
{
	Console.WriteLine(days[number_user]);
}

else
{
	Console.WriteLine("Ну ты даёшь, ха ха ха, даю подсказку их всего 7 )))");
}
			
		







					
// public class Program
// {
// 	public static void Main()
// 	{
		
// 		Console.WriteLine("Введите номер дня недели:");
// 		int day = int.Parse(Console.ReadLine());
// 		switch (day)
// 		{
// 			case 1:
// 			Console.WriteLine("понедельник");
// 			break;
// 			case 2:
// 			Console.WriteLine("вторник");
// 			break;
// 			case 3:
// 			Console.WriteLine("среда");
// 			break;
// 			case 4:
// 			Console.WriteLine("четверг");
// 			break;
// 			case 5:
// 			Console.WriteLine("пятница");
// 			break;
// 			case 6:
// 			Console.WriteLine("суббота");
// 			break;
// 			case 7:
// 			Console.WriteLine("воскресенье");
// 			break;
// 			default:
// 			Console.WriteLine("Ну ты даёшь, ха ха ха, даю подсказку их всего 7 )))");
// 			break;
// 		}
// 	}
// }         
