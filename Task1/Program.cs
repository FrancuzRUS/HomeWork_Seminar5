// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите коэфиценты для первой прямой: ");

Console.Write("k1 =  ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("b1 = : ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коэфиценты для второй прямой: ");
Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine());

int x = 0; 
int y = 0;

if (k1 == k2)
Console.WriteLine($"Прямые параллельны и не пересекаются!");

else 
{
x = (b2 - b1)/(k1 - k2);
y = k1*x+b1;
Console.WriteLine($"Точка пересечения двух прямых имеет координаты x ={x} , y ={y}");
}

