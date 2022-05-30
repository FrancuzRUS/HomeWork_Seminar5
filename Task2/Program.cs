// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

double [,] array = new double[4,2];
int i = 0 ;
int j = 0 ;
double [,] MASS = new double[4,2];
Console.WriteLine("Введите коэффициент масштабирования: ");
double k= double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты вершин: ");

for (i = 0; i<4; i++)
    for (j = 0; j<2; j++)
       { array[i,j] = double.Parse(Console.ReadLine()); }

for (i = 0; i<4; i++)
    for (j = 0; j<2; j++)
        MASS[i,j]=k*array[i,j];

for (i = 0; i<4; i++)
{ Console.WriteLine("Координаты точки ");
    for (j = 0; j<2; j++)
       { Console.WriteLine($" {MASS[i,j]}");}
}