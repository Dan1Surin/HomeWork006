// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет
// ​
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

int ROWS = new Random().Next(10,50);
int COLUMNS = new Random().Next(10,30);
const int LR = 0;
const int RR = 10;

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]+ " / ");
        }
        Console.WriteLine();
    }
}
void SearchAndPrint(int row, int column, int[,] matr)
{
    if (row > matr.GetLength(0) | column > matr.GetLength(1))
    {
        Console.WriteLine("element does not exist");  
    }
    else
    {
    int i =row-1;
    int j = column-1;
    Console.WriteLine("element = " +matr[i, j]);     
    } 
}

Console.WriteLine("row");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("column");
int y = Convert.ToInt32(Console.ReadLine());

int[,] Matrix=getRandomMatrix(ROWS,COLUMNS,LR,RR);
SearchAndPrint(x,y,Matrix);
//PrintMatrix(Matrix);
