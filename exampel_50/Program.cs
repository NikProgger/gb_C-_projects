Console.WriteLine("Введите индекс строки:");
           int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца:");
           int colums = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[6, 8];
FillArray2D(num);
PrintArray2D(num);

if (rows < num.GetLength(0) && colums < num.GetLength(1)) Console.WriteLine(num[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}