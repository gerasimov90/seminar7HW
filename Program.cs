/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()*100, 2);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого
элемента или же указание, что такого элемента нет.

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }

        Console.WriteLine();
    }
}


int rows = 4;

int columns = 4;

Console.WriteLine("Дан массив:");

int[,] result = GetMatrix(rows, columns, 0, 10);
PrintMatrix(result);

Console.WriteLine("Введите номер строки искомого элемента: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца искомого элемента: ");
int column1 = Convert.ToInt32(Console.ReadLine());

if (row1 < rows && column1 < columns) Console.WriteLine("Искомый элемент: " + result[row1,column1]);
if (row1 >= rows | column1 >= columns) Console.WriteLine("Такого элемента нет в массиве");

*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите
среднее арифметическое элементов в каждом столбце.
*/
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Строчку с индексом
        }

        Console.WriteLine(); // После строчки можно сделать перенос
    }
}


int rows = 3;

int columns = 4;

Console.WriteLine("Дан массив:");

int[,] result = GetMatrix(rows, columns, 0, 10); // Создали матрицу
PrintMatrix(result);

int[] average = new int[columns];
for (int j = 0; j < columns; j++)
{
    for (int i = 0; i < rows; i++)
    {
        average[i] += result[i,j];
    }
}
Console.WriteLine("Среднее арифметическое столбцов: ");
for (int i = 0; i < columns; i++)
{
    Console.Write(average[i]/rows + "\t");
} 
