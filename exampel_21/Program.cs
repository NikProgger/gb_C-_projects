Console.Write("Введите координату X первой точки: "); 
    int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: "); 
    int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: "); 
    int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: "); 
    int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: "); 
    int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: "); 
    int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Длинна отрезка: " + length);