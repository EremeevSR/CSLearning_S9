// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// Функция Аккермана из Википедии:
//            ________________________________________
//           |                                        |
//           | n + 1                 при m = 0        |
// A(m, n) = | A(m - 1, 1)           при m > 0, n = 0 |
//           | A(m - 1, A(m, n - 1)) при m > 0, n > 0 |
//           |________________________________________|

// Пользователь ограничен вводом положительных чисел. Опорная таблица:
// n\m  0   1   2   3   4
// 0    1   2   3   5   13
// 1    2   3   5   13  65533 <- у меня уже здесь StackOver...
// 2    3   4   7   29  очень много
// 3    4   5   9   61  очень много
// 4    5   6   11  125 очень много
// 5    6   7   13  253 очень много

Console.Write("Введите число m: ");
int m = NaturalInput();

Console.Write("Введите число n: ");
int n = NaturalInput();

Console.WriteLine($"Функция Аккермана A(m, n) = A({m}, {n}) = {Akkerman(m, n)}");


bool IsNotNegative(int number)
{
    // Метод определяет, является ли число number натуральным.

    if (number >= 0) return true;
    else return false;
}

int NaturalInput()
{
    // Метод ввода неотрицательного целого числа.

    int result = int.Parse(Console.ReadLine());
    while (!IsNotNegative(result))
    {
        Console.Write($"Число должно быть неотрицательным. Повторите ввод: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

int Akkerman(int m, int n)
{
    // Метод возвращает значение функции Аккермана.

    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return 0; // Чтобы не было "не все ветви кода возвращают значение"
}