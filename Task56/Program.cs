int[,] FillArray(int N, int M)
{
    int[,] Array = new int[N, M];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            Array[i, j] = rnd.Next(10, 20);
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
//сортировка пузырьковая
int MinSumRowIndex(int[,] Array)
{

    int index=0;
    int SumMin = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int Sum =0;
        for (int j = 0; j < Array.GetLength(1); j++)
          Sum += Array[i, j];
        if (i == 0 || SumMin > Sum)
            {
                SumMin = Sum;
                index = i;
            }
        
    }

    return index;
}
    


    System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());

int[,] Arr = FillArray(N, M);
PrintArray(Arr);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальна сумма элементов в строке {MinSumRowIndex(Arr)}");
