// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана от чисел {m} и {n} =  {ackerman(m,n)}");

int ackerman(int M, int N)
{
    if (M==0) return N+1;
    else if (N==0) return ackerman(M-1,1);
    else return ackerman(M-1, ackerman(M, N-1));
}

//  A(m,n) = n+1,                при m = 0
//         = A(m-1,1)            при m > 0, n = 0
//         = A(m-1, A(m, n-1))   при m > 0, n > 0
