
//   Написать программу масштабирования фигуры:


// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"



/////////////////////////////////////////////////////////
Console.Clear();
System.Console.WriteLine("============================================================");

Console.Write("Задайте ширину прямоугольника: ");
double width = double.Parse(Console.ReadLine()!.Replace('.', ','));
Console.Write("Задайте высоту прямоугольника: ");
double height = double.Parse(Console.ReadLine()!.Replace('.', ','));
double[] CountFigure(double[] figure, double k)
{
    for (int i = 0; i < figure.Length; i++)
    {
        figure[i] *= k;
    }

    return figure;
}
int vertices = 4;
double[] rectangle = new double[vertices * 2];

rectangle[0] = 0;
rectangle[1] = 0;
rectangle[2] = width;
rectangle[3] = 0;
rectangle[4] = width;
rectangle[5] = height;
rectangle[6] = 0;
rectangle[7] = height;

Console.WriteLine("Вершины фигуры при условии, что первая точка лежит в (0, 0): ");
Console.Write($"({rectangle[0]}, {rectangle[1]}) ");
Console.Write($"({rectangle[2]}, {rectangle[3]}) ");
Console.Write($"({rectangle[4]}, {rectangle[5]}) ");
Console.WriteLine($"({rectangle[6]}, {rectangle[7]})");

Console.Write("Задайте коэффициент масштабирования k: ");
double.TryParse(Console.ReadLine()!.Replace('.', ','), out double k);

double[] scaledRectangle = CountFigure(rectangle, k);

Console.WriteLine($"Получаем вершины фигуры в масштабе k = {k}: ");
Console.Write($"({scaledRectangle[0]}, {scaledRectangle[1]}) ");
Console.Write($"({scaledRectangle[2]}, {scaledRectangle[3]}) ");
Console.Write($"({scaledRectangle[4]}, {scaledRectangle[5]}) ");
Console.WriteLine($"({scaledRectangle[6]}, {scaledRectangle[7]})");
Console.WriteLine("============================================================");
Console.ReadLine();




////////////////////////////////////////////////

// Все примитивные типы имеют два метода, которые позволяют преобразовать строку к данному типу. Это методы Parse() и TryParse().

// Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа. 

//////////////////////////////////////////////////


//   double width = double.Parse(Console.ReadLine()!.Replace('.', ','));
//   double.TryParse(Console.ReadLine()!.Replace('.', ','), out double width); //  То же самое

