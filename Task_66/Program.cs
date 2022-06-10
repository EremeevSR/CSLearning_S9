// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

// При решении задачи пользователь ограничивается вводом
// целых натуральных чисел. Не будем при вводе требовать,
// чтобы M было строго меньше N, как в примере, или наоборот,
// но при вызове ключевого метода параметры будут передаваться
// по условию.

Console.Write("Введите первое натуральное число: ");
int m = NaturalInput();

Console.Write("Введите второе натуральное число: ");
int n = NaturalInput();

Console.Write($"Сумма натуральных чисел от {m} до {n} равна ");
if (m > n)
    Console.WriteLine($"{ReturnSumOfNaturalNums(m, n)}");
else
    Console.WriteLine($"{ReturnSumOfNaturalNums(n, m)}");

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

int ReturnSumOfNaturalNums(int from, int downTo)
{
    // Рекурсивный метод вывода суммы натуральных целых
    // чисел от from до downTo.

    if (from == downTo)
        return downTo;
    else
        return from + ReturnSumOfNaturalNums(--from, downTo);
}
