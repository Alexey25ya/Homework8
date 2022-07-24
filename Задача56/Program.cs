// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumLine(int[,] array)
{
    int index = 0;
    int minSum = Int32.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine("Сумма элементов строки " + (i + 1) + " равно: " + sum);
        if (sum < minSum)
        {
            minSum = sum;
            index=i+1;
        }

    }
    Console.WriteLine();
    Console.WriteLine("Наименьшая сумма элементов " + minSum + " находится в " + index + " строке");
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinSumLine(matrix);