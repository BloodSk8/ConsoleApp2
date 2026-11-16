using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите десятичное число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string bin = Convert.ToString(n, 2); // Встроенный метод перевода в двоичную строку

        Console.Write("Вывод: строка \"" + bin + "\"");
    }
}