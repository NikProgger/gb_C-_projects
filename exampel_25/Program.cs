Console.WriteLine("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;
int i = 1;

while (i < b )
{
    i++;
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);