// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void PrintArrayMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

int[] MinRowSum(int[,] array)
{
    int[] minMassiv = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        minMassiv[i] = sum;
    }
    return minMassiv;
}
int MinRow(int[] arraymin)
{
    int minIndex = 0;
    for (int i = 0; i < arraymin.Length; i++)
    {
        int min = arraymin[0];

        {
            if (arraymin[i] < min)
            {
                min = arraymin[i];
                minIndex = i;
            }
        }
    }
    return minIndex;
}

int cntColumns = ReadInt($"Колличество колоннок");
int cntRows = ReadInt($"Количество строк");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine();
int[] minimalRow = (MinRowSum(table));
PrintArrayMas(minimalRow);
int index = MinRow(minimalRow);
System.Console.WriteLine($"Строка с минимальной суммой элементов {index + 1} ");