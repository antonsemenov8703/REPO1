// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которое будете вводить:");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= N; i++)
{
    try
    {    
        Console.WriteLine($"Введите число № {i}:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num >0) count++;
    }
    catch (Exception)
    {
        //Console.WriteLine($"Введите число № {i}:");
    }
}
Console.WriteLine($"Вы ввели {count} положительных чисел");


// не понимаю как зациклить запрос ввода, если ввод некорректен.
