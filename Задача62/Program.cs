//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
/*1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

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

void SpiralArray(int[,] array)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < array.GetLength(0) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(1) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(0) - 1)
            j--;
        else
            i--;
        num++;
    }
}

int[,] matrix = new int[5, 5];
SpiralArray(matrix);
PrintArray(matrix);