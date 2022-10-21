// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = new Int32[4];
FillArray(array, -10, 99 );
PrintArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {notEvenPosSum(array)}");

int notEvenPosSum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
        sum += arr[i];
    }
    return sum;
}

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
}