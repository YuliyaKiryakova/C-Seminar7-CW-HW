/* Задайте двумерный массив.
Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

//первый вариант
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     return new int[rows, cols];
// }

// void Fill2DArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max + 1);
// }

// void Sum(int[,] array)
// {
//     int res = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//                 res = array[i, j] + res;
//         }
//     }
//     Console.WriteLine(res);
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minV = InputNum("Введите мин: ");
// int maxV = InputNum("Введите макс: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minV, maxV);
// Print2DArray(myArray);
// Console.WriteLine($"Сумма равна ");
// Sum(myArray);


// Второй вариант - Надежда
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int SumDiag(int[,] array)
{
    int sum = 0;
    int temp = array.GetLength(1);
    if (array.GetLength(0) < array.GetLength(1))
        temp = array.GetLength(0);
    for (int i = 0; i < temp; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int result = SumDiag(myArray);
Console.WriteLine(result);