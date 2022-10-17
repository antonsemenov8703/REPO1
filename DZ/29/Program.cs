// Задача 29: Напишите программу, которая задаёт массив произвольной длины, 
// заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или 
// попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int RandomLength ()
{
    int len = new Random().Next(2,10);
    return len;
}

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]=new Random().Next(0,100); //new создаёт новый объект
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}

Console.WriteLine("Хотите ввести длину массива вручную? Да/Нет:");
string answer = Console.ReadLine();
if(answer.ToLower() == "да" || answer.ToLower() == "yes")
{
    Console.WriteLine("Введите длину массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[length];
    Console.WriteLine($"Вы задали длину массива равной {array.Length}");
    FillArray(array);
    PrintArray(array);
}
else if (answer.ToLower() == "нет" || answer.ToLower() == "no")
{
    int[]array = new int[RandomLength()];
    Console.WriteLine($"Задана произвольная длина массива равная {array.Length}");
    FillArray(array);
    PrintArray(array);
}
else Console.WriteLine("Ответьте Да или Нет");


