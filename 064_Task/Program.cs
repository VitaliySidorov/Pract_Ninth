// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}

int PrintNatural(int number)
{
    if (number == 0)
    {
        return -1;
    }
    Console.Write("{0} ", number);
    return PrintNatural(number - 1);
}

Console.Clear();
Console.WriteLine("Программа вывода всех натуральных чисел в промежутке от n до 1.");
Console.Write("Введите число n: ");
int number = ReadNumber();
PrintNatural(number);
Console.WriteLine();