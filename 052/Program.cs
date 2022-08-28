/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void FillMtrx(double[,] mtrx)
{
    for(int i= 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMtrx(double[,] mtrx)
{
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j =0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = 3;
int column = 4;
double[,] matrix = new double[row, column];
FillMtrx(matrix);
PrintMtrx(matrix);
void SrArSt(double[,] mtrx)
{
    double mid = 0;
    int rows = mtrx.GetLength(0);
    int columns = mtrx.GetLength(1);

    for(int i = 0; i < columns; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            mid += mtrx[j, i];
        }
        Console.WriteLine(mid / rows);
        mid = 0;
    } 
    
}
SrArSt(matrix);