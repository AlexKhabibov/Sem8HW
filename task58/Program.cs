// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ArrayLengthInput()
{
    Console.WriteLine("Set the length of your two arrays");
    int userSetLength = Convert.ToInt32(Console.ReadLine());
    while (userSetLength <= 0)
    {
        Console.WriteLine("Error. Length must be  > 0! Input a number again:");
        userSetLength = Convert.ToInt32(Console.ReadLine());
    }
    return userSetLength;
}

int[,] Create2dArray(int arrayLength)
{
    int[,] created2dArray = new int[arrayLength, arrayLength];

    for (int i = 0; i < arrayLength; i++)
        for (int j = 0; j < arrayLength; j++)
            created2dArray[i, j] = new Random().Next(0, 9 + 1);

    return created2dArray;
}

void PrintTwoArrays(int[,] arrayToPrint1, int[,] arrayToPrint2)
{
    Console.WriteLine("Your first random array:");
    for (int i = 0; i < arrayToPrint1.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint1.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.WriteLine("Your second random array:");
    for (int i = 0; i < arrayToPrint2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint2.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TheSetOfTwoArrays(int[,] firstArr, int[,] secondArr)
{
    int[,] result = new int[firstArr.GetLength(0), firstArr.GetLength(0)];
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < firstArr.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < firstArr.GetLength(1); k++)
            {
                temp = temp + firstArr[i, k] * secondArr[k, j];
            }
            result[i, j] = temp;
        }
    }
    return result;
}

void PrintFinalArray(int[,] finalArrayToPrint1)
{
    Console.WriteLine("Your array after set of two arrays:");
    for (int i = 0; i < finalArrayToPrint1.GetLength(0); i++)
    {
        for (int j = 0; j < finalArrayToPrint1.GetLength(1); j++)
        {
            Console.Write($"{finalArrayToPrint1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int userLen = ArrayLengthInput();
int[,] arrayMatr1 = Create2dArray(userLen);
int[,] arrayMatr2 = Create2dArray(userLen);
PrintTwoArrays(arrayMatr1, arrayMatr2);
int[,] arrayMulti = TheSetOfTwoArrays(arrayMatr1, arrayMatr2);
PrintFinalArray(arrayMulti);