int[,] FillArray(int N, int M)
{
    int[,] Array = new int[N, M];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            Array[i, j] = rnd.Next(-10, 11);
    return Array;
}

//печать массива
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
(bool, int[,]) MatrixMultiplication(int[,] Arr1, int[,] Arr2)
{


    int n = Arr1.GetLength(0);
    int m = Arr1.GetLength(1);
    int p = Arr2.GetLength(1);
    int[,] Result = new int[n, p];
    if (Arr1.GetLength(1) != Arr2.GetLength(0))
        return (false, Result);
    for (int i = 0; i < n; i++)
        for (int j = 0; j < p; j++)
            for (int k = 0; k < m; k++)
                Result[i, j] += Arr1[i, k] * Arr2[k, j];

    return (true, Result);
}



System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" P = ");
int P = Convert.ToInt32(Console.ReadLine());

int[,] Arr1 = FillArray(N, M);
int[,] Arr2 = FillArray(M, P);

PrintArray(Arr1);
System.Console.WriteLine();
PrintArray(Arr2);
System.Console.WriteLine();
var (Flag, Arr) = MatrixMultiplication(Arr1, Arr2);
if (Flag)
    {   System.Console.WriteLine("Произведение матриц : ");
        PrintArray(Arr);
    }    
else
    System.Console.WriteLine("Умножение невозможно");