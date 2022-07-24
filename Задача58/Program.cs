// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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

int[,] MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return resultArray;
}
int[,] arr1 = new int[3, 4];
int[,] arr2 = new int[3, 4];
Console.WriteLine("Первая матрица:");
FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
FillArray(arr2);
PrintArray(arr2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(MultiplyArray(arr1, arr2));
