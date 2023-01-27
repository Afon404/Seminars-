/////////   ТЕРНАРНЫЙ ОПЕРАТОР | ЧТО ЭТО | ПРИМЕР | КАК ИСПОЛЬЗОВАТЬ 
// Сначала приведён пример с if(){}  else{}, а ниже ТЕРНАРНЫЙ ОПЕРАТОР

// Console.Write("Введите пароль: ");
// string entredPassword = Console.ReadLine();
// string correctPassword  = "qqq";
// bool accessAllowed;
// if(entredPassword == correctPassword)
// {
//     accessAllowed = true;
// }
// else
// {
//     accessAllowed = false;
// }
// System.Console.WriteLine(accessAllowed);


//////////////////////////////   2 //////////////////////////


// Console.Write("Введите пароль: ");
// string entredPassword = Console.ReadLine();
// string correctPassword  = "qqq";
// bool accessAllowed;

// accessAllowed = entredPassword == correctPassword ? true : false;  // ТЕРНАРНЫЙ ОПЕРАТОР
//                                                                 //  тоже самое что и if(){} ||  else{}
// Console.WriteLine(accessAllowed);



//////////////////////////////   3 //////////////////////////

string text = "а если отрицательное то покажет 0 ";
Console.WriteLine($"Если число положительное то покажет Ваше число {text}");
Console.Write("Введите число: ");
int inputData = int.Parse(Console.ReadLine()!);
int outputData = (inputData < 0) ? 0 : inputData;


Console.WriteLine(outputData);
