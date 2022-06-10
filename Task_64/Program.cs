// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// При решении задачи пользователь ограничивается вводом
// целых натуральных чисел.

Console.Write("Введите целое натуральное число: ");

int userNum = NaturalInput();

PrintNaturalNums(userNum);
Console.WriteLine();

bool IsNatural(int number)
{
    // Метод определяет, является ли число number натуральным.

    if (number >= 1) return true;
    else return false;
}

int NaturalInput()
{
    // Метод ввода целого натурального числа.

    int result = int.Parse(Console.ReadLine());
    while (!IsNatural(result))
    {
        Console.Write($"Число должно быть больше нуля. Повторите ввод: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

void PrintNaturalNums(int num)
{
    // Рекурсивный метод вывода натуральных целых
    // чисел от num до 1.

    Console.Write($"{num}");
    if (num > 1)
    {
        Console.Write(", ");
        PrintNaturalNums(--num);
    }
}