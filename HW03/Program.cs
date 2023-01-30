// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] getRandomMatrix(int rows, int columns, int lRange, int rRange)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(lRange, rRange + 1);
        }
    }
    return matrix;
}

int ROWS = 5;
int COLUMNS = 5;
const int LR = 0;
const int RR = 10;

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]+ " ");
        }
        Console.WriteLine();
    }
}
int[,] Matrix=getRandomMatrix(ROWS,COLUMNS,LR,RR);
PrintMatrix(Matrix);

void ArithmeticMeanColumn(int[,] matr)
{   double av = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            av = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                av =av + Matrix[i,j];
                
            }
            Console.Write($"{av/matr.GetLength(1):f1}" + " ; ");
        }
}
ArithmeticMeanColumn(Matrix);


