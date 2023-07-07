// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dArray()
{
    Console.WriteLine("Input count of rows");
    int myRows = Convert.ToInt32(Console.ReadLine());
    while (myRows <= 0)
    {
        Console.WriteLine("Error. Try again!");
        myRows = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Input count of columns");
    int myColumns = Convert.ToInt32(Console.ReadLine());
    while (myColumns <= 0)
    {
        Console.WriteLine("Error. Try again!");
        myColumns = Convert.ToInt32(Console.ReadLine());
    }

    int[,] created2dArray = new int[myRows, myColumns];

    for (int i = 0; i < myRows; i++)
        for (int j = 0; j < myColumns; j++)
            created2dArray[i, j] = new Random().Next(0, 9 + 1);

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

int[,] Sorted2dArray(int[,] arrayToSort)
{
    int max = 0;
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
        for (int j = 0; j < arrayToSort.GetLength(1); j++)
        {
            for (int newColumn = 0; newColumn < arrayToSort.GetLength(1) - 1; newColumn++)
            {
                if (arrayToSort[i, newColumn] < arrayToSort[i, newColumn + 1])
                {
                    max = arrayToSort[i, newColumn + 1];
                    arrayToSort[i, newColumn + 1] = arrayToSort[i, newColumn];
                    arrayToSort[i, newColumn] = max;
                }
            }

        }
    return arrayToSort;
}

int[,] userArray = Create2dArray();
Console.WriteLine("Array is:");
Print2dArray(userArray);
int[,] sortedArray = Sorted2dArray(userArray);
Console.WriteLine("Sorted Array is:");
Print2dArray(sortedArray);