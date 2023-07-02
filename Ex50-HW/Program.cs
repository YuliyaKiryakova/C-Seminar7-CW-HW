/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

/* сложный вариант (17 это порядковый номер элемента массива)
*/
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

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение: ");
int maxValue = InputNum("Введите максимальное значение: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);

int ordinal = InputNum("Введите порядковый номер элемента массива: ");

if (ordinal <= rows * cols)
    Console.WriteLine($"Значение элемента на данной позиции равно {myArray[(ordinal - 1) / cols, (ordinal - 1) % cols]}");
else
    Console.WriteLine("Такого порядкового номера нет в данном массиве");


/* первый простой вариант (17 это i=1 j=7) 
*/
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
// int minValue = InputNum("Введите минимальное значение: ");
// int maxValue = InputNum("Введите максимальное значение: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);

// int rowNum = InputNum("Введите номер строки: ");
// int colNum = InputNum("Введите номер столбца: ");

// if (rowNum < rows && colNum < cols)
//     Console.WriteLine($"Значение элемента на данной позиции равно {myArray[rowNum, colNum]}");
// else
//     Console.WriteLine("Такой позиции нет в данном массиве");


/* второй простой вариант (17 это i=1 j=7) void сделала, может это и бессмысленнно))
*/
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

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");
//         Console.WriteLine();
//     }
// }

// void PrintElement(int[,] array, int rowNum, int colNum, int rows, int cols)
// {
//     if (rowNum < rows && colNum < cols)
//         Console.WriteLine($"Значение элемента на данной позиции равно {array[rowNum, colNum]}");
//     else
//         Console.WriteLine("Такой позиции нет в данном массиве");
// }

// int rows = InputNum("Введите количество строк: ");
// int cols = InputNum("Введите количество столбцов: ");
// int minValue = InputNum("Введите минимальное значение: ");
// int maxValue = InputNum("Введите максимальное значение: ");
// int rowNumber = InputNum("Введите номер строки: ");
// int colNumber = InputNum("Введите номер столбца: ");

// int[,] myArray = Create2DArray(rows, cols);
// Fill2DArray(myArray, minValue, maxValue);
// Print2DArray(myArray);
// PrintElement(myArray, rowNumber, colNumber, rows, cols);
