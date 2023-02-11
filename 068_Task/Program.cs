// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать целое неотрицательное число, попробуйте еще раз.");
    }
}

int AkkermanFunction(int m, int n) // Рекурсивный метод вычисления функции Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.Clear();
Console.WriteLine("Программа вычисления функции Аккермана A(m, n).");
Console.Write("Введите число m: ");
int m = ReadNumber();
Console.Write("Введите число n: ");
int n = ReadNumber();

Console.WriteLine("A({0}, {1}) = {2}", m, n, AkkermanFunction(m, n));