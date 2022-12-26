// 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] GetMatrix(int m, int n, int minV, int maxV)

{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minV, maxV+1);
        }
    }
    return matrix;
}

int[,] GetMatrixQ(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j], 2));
        }
        
    }
    return matrix;
}


void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        Console.Write(inputArray[i,j] + "\t ");
    }
       Console.WriteLine();
    }
}

int[,] newArray = GetMatrix(3, 4, 0, 99);
PrintArray(newArray);
Console.WriteLine();
newArray = GetMatrixQ(newArray);
PrintArray(newArray);
    

































