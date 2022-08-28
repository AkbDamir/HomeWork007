/*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void FillMtrx(int[,] mtrx)
{
    for(int i = 0; i < mtrx.GetLength(0); i++)
    {
        for(int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMtrx(int[,] mtrx)
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

int[,] matrix = new int [3, 4];
FillMtrx(matrix);
Console.Write("Введите ваше число: ");
int n = int.Parse(Console.ReadLine());
PrintMtrx(matrix);
void ProvArr(int[,] mtrx)
{
    int sum = 0;
    for(int i = 0; i < mtrx.GetLength(0); i++)
        {
            for(int j = 0; j < mtrx.GetLength(1); j++)
            {
                if(mtrx[i, j] == n) 
                {
                    Console.WriteLine($"{i}, {j}");
                    sum++;                    
                }
                
                

            }
        }
    if(sum == 0) Console.WriteLine("такого числа в массиве нет");
}
ProvArr(matrix);