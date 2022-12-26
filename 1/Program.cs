// Задача 46: Задайте двумерынй массив размером MxN, заполненный случайныи целыми числами.
// m = 3, n = 4,
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// int[,] -> int [rows, cols]
// Матрица прямоугольная таблица, с размером m * n
// Квадратная матрица - таблица, у которой кол-во строк = кол-во столбцов
// Прямоугольная матрица - таблица, у которой кол-во строк !=(не равно) кол-во столбцов
// m- кол-во стр, n - кол-во столбцов


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; 
    for (int i = 0; i < matrix.GetLength(0); i++)      // [rows(0), columns(1)] Чтобы получить кол-во строк, мы указываем GetLength(0), matrix.GetLength(0) = m - по строчкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // j, m, k
            //    matrix.GetLength(1) = n, по столбцам
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // Литерал, он позволяет сделать отступ в виде Таб-а
        }
         Console.WriteLine(); // После строчки можно сделать перенос строки    
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = GetMatrix(rows, columns, 0, 10); // Создали матрицу

PrintMatrix(result);




