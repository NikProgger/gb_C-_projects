int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] num = new int[size];

FillArrayRandomNumbers(num);
PrintArray(num);
int res = 0;

for (int i = 0; i < num.Length; i++)
{
    if (i % 2 != 0)
    {
        res += num[i];
    }
}
Console.WriteLine("Сумма элементов нечетных позиций " + res);

void FillArrayRandomNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}