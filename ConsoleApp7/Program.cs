using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int N = 20; // Наприклад, створюємо колекцію з 20 чисел

        // Створення колекції випадкових чисел в інтервалі [5; 25]
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(5, 26));
        }

        Console.WriteLine("Початкова колекція:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Пошук та видалення останнього числа, яке закінчується на 1
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] % 10 == 1)
            {
                numbers.RemoveAt(i);
                break;
            }
        }

        Console.WriteLine("Колекція після видалення останнього числа, яке закінчується на 1:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
