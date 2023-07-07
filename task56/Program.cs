// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Create2dArray()
{
    Console.WriteLine("Input count of rows");
    int arrayRows = Convert.ToInt32(Console.ReadLine());
    while (arrayRows <= 0)
    {
        Console.WriteLine("Error. Try again!");
        arrayRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Input count of columns");
    int arrayColumns = Convert.ToInt32(Console.ReadLine());
    while (arrayColumns <= 0)
    {
        Console.WriteLine("Error. Try again!");
        arrayColumns = Convert.ToInt32(Console.ReadLine());
    }

    int[,] created2dArray = new int[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
        for (int j = 0; j < arrayColumns; j++)
            created2dArray[i, j] = new Random().Next(1, 9 + 1);

    return created2dArray;
}

void Print2dArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SummOfElemsInRow(int[,] arrayToSumm, int i)
{
    int sumInRow = arrayToSumm[i, 0];
    for (int j = 1; j < arrayToSumm.GetLength(1); j++)
    {
        sumInRow = sumInRow + arrayToSumm[i, j];
    }
    return sumInRow;
}

void MinSumRow(int[,] myArray)
{
    int minSumRow = 0;
    int sumRow = SummOfElemsInRow(myArray, 0);
    for (int i = 1; i < myArray.GetLength(0); i++)
    {
        int tempSum = SummOfElemsInRow(myArray, i);
        if (sumRow > tempSum)
        {
            sumRow = tempSum;
            minSumRow = i;
        }
    }
    Console.WriteLine($"The row number {minSumRow + 1} has the minimum sum in the array rows.");
    Console.WriteLine($"Sum of elements from row number {minSumRow + 1} is: {sumRow}");
}


int[,] userArray = Create2dArray();
Console.WriteLine("Your random array is:");
Print2dArray(userArray);
MinSumRow(userArray);