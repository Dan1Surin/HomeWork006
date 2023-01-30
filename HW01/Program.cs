// Домашняя работа:
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​ 
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9
// ​

double[,] getRandomMatrix(int rows, int columns, int lRange, int rRange)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double x = new Random().NextDouble();
            int y = new Random().Next(lRange,rRange+1);
            matrix[i, j] = x*y;
        }
    }
    return matrix;
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LR = -100;
const int RR = 100;

double[,] Matrix=getRandomMatrix(ROWS,COLUMNS,LR,RR);

void PrintMatrix(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f1}"+ " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(Matrix);