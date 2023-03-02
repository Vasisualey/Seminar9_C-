// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine ($"A ({m}, {n}) = {FunAkk (m, n)}");

int FunAkk (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (n == 0)
    {
        return FunAkk (m - 1, 1);
    }
    else
    {
        return FunAkk (m - 1, FunAkk (m, n - 1));
    }
}

// Эльвира, при условии если M =4 и N = 4, оно уже не работает и выдает ошибку, но работает при M < 4. 
// Я гуглил и вроде там говорят что она "быстрорастущая", и такой баг вроде как нормальный, поэтому сдаю так =(
// тем более до дедлайна осталось 5 минут, не успею с ней повозиться.
