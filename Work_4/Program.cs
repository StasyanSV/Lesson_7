// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

Console.Clear();

Console.Write("Введите колличество строк: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(lines, columns, 0, 10);
PrintGetArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали равна {SumDiagonalArray(array)}");


int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return result;
}

void PrintGetArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumDiagonalArray(int[,] inArray)
{
    int result = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j)
            {
                result += inArray[i, j];
            }
        }
    }

    return result;
}