// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] XYZ()
{
    Console.WriteLine($"Input your X: ");
    int userX = Convert.ToInt32(Console.ReadLine());
    while (userX <= 0)
    {
        Console.WriteLine($"Error. X must be > 0. Input your X again: ");
        userX = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Input your Y: ");
    int userY = Convert.ToInt32(Console.ReadLine());
    while (userY <= 0)
    {
        Console.WriteLine($"Error. Y must be > 0. Input your Y again: ");
        userY = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Input your Z: ");
    int userZ = Convert.ToInt32(Console.ReadLine());
    while (userZ <= 0)
    {
        Console.WriteLine($"Error. Z must be > 0. Input your Z again: ");
        userZ = Convert.ToInt32(Console.ReadLine());
    }

    int[] userData = new int[3];
    userData[0] = userX;
    userData[1] = userY;
    userData[2] = userZ;

    return userData;
}

int[,,] Create3DArray(int[] userCoords)
{
    int[,,] created3DArray = new int[userCoords[0], userCoords[1], userCoords[2]];
    for (int i = 0; i < userCoords[0]; i++)
        for (int j = 0; j < userCoords[1]; j++)
            for (int k = 0; k < userCoords[2]; k++)
                created3DArray[i, j, k] = Convert.ToInt32(new Random().Next(10, 100));
    return created3DArray;
}

void Show3DArray(int[,,] arrayToShow)
{

    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToShow.GetLength(2); k++)
            {
                Console.Write($"{arrayToShow[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] arrayUser = Create3DArray(XYZ());
Show3DArray(arrayUser);