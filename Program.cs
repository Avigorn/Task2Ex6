// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

double[,] GenerateArray(double rows, double cols)
{
    int rowsI = Convert.ToInt32(rows);
    int colsN = Convert.ToInt32(cols);
    double[,] arrayD2 = new double[rowsI, colsN];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int n = 0; n < arrayD2.GetLength(1); n++)
        {
            arrayD2[i, n] = new Random().Next(0, 10);
        }
    }
    return arrayD2;
}

void ShowArray(double[,] array)
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

void ReceiveMeanArrCols(double rows, double cols)
{
    double[,] arr = GenerateArray(rows, cols);
    double[] Numbers = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            result += arr[j, i];
        }
        Numbers[i] = result / arr.GetLength(0);
        System.Console.WriteLine($"Среднее арифметическое {i+1}-ого столбца равно {Numbers[i]}\t");
    }
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
double[,] arr = GenerateArray(rows, columns);
ShowArray(arr);
ReceiveMeanArrCols(rows, columns);
