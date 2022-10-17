// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вариант №1

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int NumberSum(int num)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number%10;
//         number = number/10;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма цифр в числе {number} = {NumberSum(number)} ");


// Вариант №2

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int NumberSum2(string num)
{
    int length = number.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        result = result + Convert.ToInt32(Convert.ToString(number[i]));// Из символов мы перевели в строку, 
// чтобы i-ое значение строки уже перевести в число и произвести с ним вычисления. 
// Когда мы по индексу из строки вытаскиваем значение, то у него итерация в типе char - т.е. 
// символ, а не число. Строка воспринимается как массив из char символов.
    }
    return result;
}
Console.WriteLine(NumberSum2(number));