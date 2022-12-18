int main(int a)
{
    int result = ((a / 10) % 10);
    return result;
}

    Console.Write("Введите 3х-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
    Console.WriteLine($"Второе число:{main(number)}");