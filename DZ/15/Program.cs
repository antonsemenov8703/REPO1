// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay<1|weekDay>7)
{
    Console.WriteLine("В неделе всего 7 дней ");
}
else if (weekDay==6|weekDay==7)
{
    Console.WriteLine("Да, " + weekDay + "-ой день является выходным");
}
else 
{
    Console.WriteLine("Нет, это будний день");
}