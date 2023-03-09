// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[columns, rows];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int NumberRowSmallestSumElementsArray(int[,] array)
{
    int sumElemetnsInRow = 0;
    int[] arrSumsRowsInArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumElemetnsInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElemetnsInRow += array[i, j];
        }
        arrSumsRowsInArray[i] = sumElemetnsInRow;
    }

    int NumberMinRow = 0;
    int minSumElemetnsInRow = arrSumsRowsInArray[0];
    for (int i = 0; i < arrSumsRowsInArray.Length; i++)
    {
        if (minSumElemetnsInRow > arrSumsRowsInArray[i])
        {
            minSumElemetnsInRow = arrSumsRowsInArray[i];
            NumberMinRow = i;
        }
    }
    return NumberMinRow + 1;

}

int[,] arr = GenerateArray(4, 3);
PrintArray(arr);
System.Console.WriteLine();
System.Console.Write($"Номер строки с наименьшей суммой элементов: {NumberRowSmallestSumElementsArray(arr)} строка");