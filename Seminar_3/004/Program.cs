


     ///   Показать кубы чисел, заканчивающихся на четную цифру



Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 30);
System.Console.WriteLine($"N = {N}");

// решение циклом

int number = 1;
System.Console.WriteLine("By While");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
    number++;
}
System.Console.WriteLine();





// решение  методом

System.Console.WriteLine("By Method 1:");

int[] GetEvenCubeArray(int N)
{
    int num = 1;
    int i = 0;
    int[] EvenCubs = new int[N];
    while (num <= N)
    {
        int cube = num * num * num;
        if (cube % 2 == 0)
        {
            EvenCubs[i] = cube;
            i++;
        }
        num++;
    }
    return EvenCubs;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(GetEvenCubeArray(N));





// еще один способ: собрать массив из кубов, а на печать вывести только четные

System.Console.WriteLine("By Method 2");

int[] GetCubeArray(int N)
{
    int i = 0;
    int[] EvenCubs = new int[N];
    for (int num = 1; num <= N; num++)
    {
        EvenCubs[i] = num * num * num;
        i ++;
    }
    return EvenCubs;
}

void PrinEvenCubes(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
PrinEvenCubes(GetCubeArray(N));
System.Console.WriteLine();




   //////////////////////////////////////////////////////





//  Если имеется в виду какое-то одно число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 10 % 2 == 0)
{
    Console.WriteLine("Число " + number + " заканчивается на чётную цифру. " + number + " в кубе равно " + (number * number * number));
}
else
{
    Console.WriteLine("Число " + number + " не заканчивается на чётную цифру, условие задачи не соблюдено.");
}

// Варинт 2. Если имеется в виду числа от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 2;
int value = 0;

while (i <= N)
{
    value = i * i * i;
    Console.WriteLine(i + " в кубе равно " + value);
    i += 2;
}