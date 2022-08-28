/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void FillMatr (double[,] mtrx)
{
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(-10,10);
        }
    }
}
void PrintMtrx(double[,] mtrx)
{
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

double[,] matrix = new double[n, m];
FillMatr(matrix);
PrintMtrx(matrix);
