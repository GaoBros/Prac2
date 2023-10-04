using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в мою вторую практичемкую по C#");
        Console.WriteLine("Выберите программу:");
        Console.WriteLine("1. Игра \"Угадай число\"");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Выход из программы");

        int vybor = int.Parse(Console.ReadLine());

        switch (vybor)
        {
            case 1:
                UgdChisl();
                break;
            case 2:
                TablUmnj();
                break;
            case 3:
                DelChill();
                break;
            case 4:
                Vyhod();
                break;
            default:
                Console.WriteLine("Ошибка: неверный выбор");
                break;
        }
    }

    static void UgdChisl()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempts = 0;

        Console.WriteLine("Игра \"Угадай число\"!");
        Console.WriteLine("Загадано число от 1 до 100. Попробуйте угадать его.");

        while (true)
        {
            Console.Write("Введите число: ");
            int guess = int.Parse(Console.ReadLine());

            attempts++;

            if (guess < numberToGuess)
                Console.WriteLine("Загаданное число больше.");
            else if (guess > numberToGuess)
                Console.WriteLine("Загаданное число меньше.");
            else
            {
                Console.WriteLine("Поздравляю! Ты угадал число за " + attempts + " попыток.");
                break;
            }
        }
    }

    static void TablUmnj()
    {
        int size = 10; 
        int[,] tbmj = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                tbmj[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(tbmj[i, j] + "\t");
            }
            Console.Write("\n");
        }
    }

    static void DelChill()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Делители числа " + number + ": ");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
    static void Vyhod()
    {
        Environment.Exit(0);
    }
}