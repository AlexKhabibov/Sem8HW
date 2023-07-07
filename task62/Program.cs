// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputArraySize()
{
    Console.WriteLine("Input the size of your array (it will be the same length of rows and columns): ");
    int userSize = Convert.ToInt32(Console.ReadLine());
    while (userSize <= 0)
    {
        Console.WriteLine("Error. It must be > 0.  ");
        userSize = Convert.ToInt32(Console.ReadLine());
    }
    return userSize;
}

double[,] SpiralArrayCreation(int sizeFromUser)
{
    double[,] spiralArray = new double[sizeFromUser, sizeFromUser];

    int elementVal = 1;
    int i = 0;
    int j = 0;

    while (elementVal <= sizeFromUser * sizeFromUser)
    {
        spiralArray[i, j] = elementVal;
        elementVal++;
        if (i <= j + 1 && i + j < sizeFromUser - 1) j++;
        else if (i < j && i + j >= sizeFromUser - 1) i++;
        else if (i >= j && i + j > sizeFromUser - 1) j--;
        else i--;
    }
    return spiralArray;
}


void PrintArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j].ToString().PadLeft(2, '0')} ");
        }
        Console.WriteLine();
    }
}

double[,] userSpiralArr = SpiralArrayCreation(InputArraySize());
PrintArray(userSpiralArr);