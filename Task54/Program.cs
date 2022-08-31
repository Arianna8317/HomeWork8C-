int[,] FillArray(int N, int M)
{
    int[,] Array = new int[N, M];
    Random rnd = new Random();
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
            Array[i, j] = rnd.Next(-100, 101);
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
//сортировка пузыр
int[,]  DescendRows(int[,] Array)
{
    //int max;
    int temp;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
    
      for (int k = 0; k <Array.GetLength(1)-1; k++)
      {       
        for (int j = 0; j+1 < Array.GetLength(1)-k ; j++)
        {   
            if ( Array[i,j]< Array[i, j+1])
            {  temp = Array[i,j];
                Array[i,j]=Array[i,j+1];
                Array[i, j+1] = temp;
            }
        }    
        
      }
    } 
    return Array;
}


    System.Console.Write(" N = ");
    int N = Convert.ToInt32(Console.ReadLine());
    System.Console.Write(" M = ");
    int M = Convert.ToInt32(Console.ReadLine());

    int[,] Arr = FillArray(N, M);
    PrintArray(Arr);
    System.Console.WriteLine();
    PrintArray(DescendRows(Arr));