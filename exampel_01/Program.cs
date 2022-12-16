
Console.WriteLine("Здравствуйте, Ведите первое число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите Второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(b);

 if (a > b)
    {
         Console.WriteLine("Первое число " + a + " больше чем второе " + b);
    }
            else
                {
                    Console.WriteLine("Второе число " + b + " больше чем первое " + a);
                }