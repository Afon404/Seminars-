

    // ПЕРЕГРУЗКА МЕТОДОВ 

 // 
class Program 
{
    
    static int Sum2(int a, int b, int c)
    {
        return a * b / c;
    }
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Sum(double a, double b, double c)
    {
        return  a + b + c;
    }

    static void Main(string[] args)
    {
        double result = Sum2(5, 5, 4);   // Так как мы указали 3 параметра, вызвался метод с 2 параметрами.
        System.Console.WriteLine(result);  // А если параметры одинаковы тогда меняем имя метода.
    }

}