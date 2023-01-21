 //   Показать кубы чисел, заканчивающихся на четную цифру .


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)  
{
    int sum = num * num * num ;
    Console.WriteLine("Число {0} заканчивается на чётную цифру. {0} в кубе = {1}", num, sum);
}
else
{
    Console.WriteLine("Число {} не заканчивается на чётную цифру, условие задачи не соблюдено.", num);
}
