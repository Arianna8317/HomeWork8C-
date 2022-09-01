(bool, int[,,]) FillArray(int N, int M, int P, int Start, int End )
{
    
    int[,,] Array = new int[N, M, P];
    if ( N*M*P > End+1-Start)
      return ( false, Array); 
    Random rnd = new Random();
    List<int> UsedNumbers=new List<int>{0}; // уже сгенерированные числа
    for (int i = 0; i < N; i++)
        for (int j = 0; j < M; j++)
           for (int k = 0;  k < P;  k++)
            { 
                 Array[i, j, k] = rnd.Next(Start, End+1);
                 while ( (UsedNumbers.Contains(Array[i,j,k])))
                        Array[i,j,k]=System.Random.Shared.Next(Start, End +1);
                        
                 UsedNumbers.Add(Array[i,j,k]);
            } 
    return ( true,Array);
}

//печать массива
void Print3Array(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
           for (int k = 0; k < Array.GetLength(2); k++)
              Console.WriteLine($"{Array[i, j, k]} ({i},{j},{k}) ");
    
    }
}


System.Console.Write(" N = ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" M = ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write(" P = ");
int P = Convert.ToInt32(Console.ReadLine());
int start = 10; // двузначные числа
int end = 100;
var (Flag, Arr) = FillArray(N, M, P, start, end);
if (Flag)
   Print3Array(Arr);
else 
   System.Console.WriteLine("Невозможна генерация неповторяющихся чисел ");