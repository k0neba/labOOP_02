using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int N = 20; // Наприклад, створюємо колекцію з 20 чисел

        // Створення колекції випадкових чисел в інтервалі [1; 20]
        List<int> numbers = new List<int>();
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(1, 21));
        }

        Console.WriteLine("Початкова колекція:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Розділення на парні та непарні числа
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }

        Console.WriteLine("Колекція парних чисел:");
        foreach (int number in evenNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Колекція непарних чисел:");
        foreach (int number in oddNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
