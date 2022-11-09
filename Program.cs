
/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetNumber(string message)

{

    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}      ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double colAvr = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            colAvr += matrix[i, j];
        }
        colAvr = Math.Round((colAvr / matrix.GetLength(0)), 2);
        Console.Write(colAvr + " ****** ");
    }
}
int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int k = GetNumber("Введите номер в сторке:");
int l = GetNumber("Введите номер в столбце:");
int[,] matrix = InitMatrix(k, l);
PrintMatrix(matrix);
Console.WriteLine("************");
Console.WriteLine();
Average(matrix);
Console.WriteLine();
