int main(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
        
        Console.Write("Введите 3х-значное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (main(number1) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третье число это {main(number1)}");