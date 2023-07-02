/* Двумерные массивы
Задайте двумерный массив размером m×n,
заполненный случайными целыми числами
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
int minV = InputNum("Введите мин: ");
int maxV = InputNum("Введите макс: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minV, maxV);
Print2DArray(myArray);


// int a = 1;
// int b = 2;
// Console.WriteLine($"{a} + {b}\nИтого {a + b}\n");
// Console.WriteLine("!");
