// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

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

void PrintDArray(int[,] array)
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

void Print2DArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int d = 0; d < array.GetLength(1); d++)
        {
            System.Console.Write($"{array[k, d]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] multiplicationsTable(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < result.GetLength(1) - 1; j++)
        {
            result[i, j] = array1[i, j] * array2[i, j] + array1[i, j + 1] * array2[i + 1, j];
        }
    }
    return result;
}

int cntColumns = ReadInt($"Колличество колоннок 1 массива");
int cntRows = ReadInt($"Количество строк 1 массива");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine();
int cntColumns1 = ReadInt($"Колличество колоннок 2 массива");
int cntRows1 = ReadInt($"Количество строк 2 массива");
int[,] table1 = Generate2DArray(cntColumns1, cntRows1);
PrintDArray(table1);
System.Console.WriteLine();
int[,] massive1 = Generate2DArray(cntRows, cntColumns);
int[,] massive2 = Generate2DArray(cntRows1, cntColumns1);
if (cntColumns == cntRows1)
{
    Print2DArray(multiplicationsTable(massive1, massive2));
}
else System.Console.Write("Умножение матриц невозможно");
