// Задача 60. ...НДК
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] array = new int[2, 2, 2];
FillArray(array);
Console.WriteLine();

PrintArray(array);

void FillArray(int[,,] matr)
{
    int value = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                value = new Random().Next(10, 100);
                for (int x = 0; x <= i; x++)
                {
                    for (int y = 0; y <= j; y++)
                    {
                        for (int z = 0; z <= k; z++)
                        {
                            if (value == matr[x,y,z])
                            { 
                                value = new Random().Next(10, 100);
                                matr[i, j, k] = value;
                            }
                            else break;
                        }
                    }
                }
                matr[i, j, k] = value;
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
