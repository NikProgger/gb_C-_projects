Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(num, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " - ");
    }
}