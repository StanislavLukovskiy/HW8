// Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Decreasing(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int d = 0; d < array.GetLength(1) - 1; d++)
            {
                if (array[i, d] < array[i, d + 1])
                {
                    int number = array[i, d + 1];
                    array[i, d + 1] = array[i, d];
                    array[i, d] = number;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int cntColumns = ReadInt($"Колличество колоннок");
int cntRows = ReadInt($"Количество строк");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine();
int[,] dec = Decreasing(table);
PrintArray(Decreasing(table));