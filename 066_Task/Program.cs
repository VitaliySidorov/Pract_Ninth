// Задача 66: Задайте значения m и n. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от m до n.
// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30

int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать натуральное число, попробуйте еще раз.");
    }
}

int SumBetweenMN(int m, int n) // Рекурсивный метод нахождения суммы натуральных элементов в промежутке [m, n]
{
    if (m == n)
    {
        return m;
    }    
    else if (m < n) // Проверка чисел на больше-меньше для определения направления суммирования
    {
        return n + SumBetweenMN(m, n - 1);
    }
    else 
    {
        return n + SumBetweenMN(m, n + 1);
    }

}

Console.Clear();
Console.WriteLine("Программа нахождения суммы натуральных элементов в промежутке [m, n].");
Console.Write("Введите число m: ");
int m = ReadNumber();
Console.Write("Введите число n: ");
int n = ReadNumber();
Console.WriteLine($"Сумма натуральных элементов в промежутке [{m}, {n}] равна {SumBetweenMN(m, n)}.");