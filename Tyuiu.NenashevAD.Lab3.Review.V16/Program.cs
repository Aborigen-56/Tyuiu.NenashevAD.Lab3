using System;
using SolveMathFirstExpression.Lib;
using SolveMathSecondExpression.Lib;
using SolveTabMathFuction.Lib;
using SolveCalculate.Lib;
using SolveArray.Lib;
using Array = SolveArray.Lib.Array;

namespace Tyuiu.NenashevAD.Lab3.Review.V16
{
    internal class Program
    {
        public static int indexItem;

        static void UpArrow()
        {
            indexItem--;
            if (indexItem < 1)
            {
                indexItem = 5;
            }
            drawMainMenu();
        }

        static void DownArrow()
        {
            indexItem++;
            if (indexItem > 5)
            {
                indexItem = 1;
            }
            drawMainMenu();
        }

        static void selectItem()
        {
            switch(indexItem)
            {
                case 1:
                    Option1();
                    break;
                case 2:
                    Option2();
                    break;
                case 3:
                    Option3();
                    break;
                case 4:
                    Option4();
                    break;
                case 5:
                    Option5();
                    break;
            }
        }

        static void Option1()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("РАССЧИТАТЬ ПЕРВОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 3);

            Console.WriteLine("\nВыполняется функция: Расчет первого математического выражения");
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            int y = int.Parse(Console.ReadLine());

            MathFirstExpression mathFirstExpression = new MathFirstExpression();
            double result = mathFirstExpression.CalculateFirstExpression(a, x, y);

            Console.WriteLine($"Результат: {result}");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option1();
            }
        }

        static void Option2()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("РАССЧИТАТЬ ВТОРОЕ МАТЕМАТИЧЕСКОЕ ВЫРАЖЕНИЕ");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);

            Console.WriteLine("\nВыполняется функция: Расчет второго математического выражения");
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            MathSecondExpression mathSecondExpression = new MathSecondExpression();
            double result = mathSecondExpression.CalculateSecondExpression(a, x, y);

            Console.WriteLine($"Результат: {result}");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option2();
            }
        }

        static void Option3()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("ПРОТАБУЛИРОВАТЬ ФУНКЦИЮ НА ЗАДАННОМ ДИАПОЗОНЕ");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);

            Console.WriteLine("\nВыполняется функция: Протабулировать функцию на заданном диапазоне");
            Console.Write("Введите начальное значение диапазона: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение диапазона: ");
            int end = int.Parse(Console.ReadLine());

            TabMathFuction tabMathFuction = new TabMathFuction();
            double[] results = tabMathFuction.CalculateTabMathFuction(start, end);

            Console.WriteLine("Результаты табуляции:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|   x   |     f(x)    |");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < results.Length; i++)
            {
                int x = start + i;
                string fx = results[i].ToString();
                Console.WriteLine($"| {x,5} | {fx,11} |");
            }
            Console.WriteLine("-----------------------");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option3();
            }
        }

        static void Option4()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("КАЛЬКУЛЯТОР");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);

            Console.WriteLine("\nВыполняется функция: Калькулятор");
            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            Calculate calculate = new Calculate();
            double sum = calculate.CalculateSumma(a, b);
            double difference = calculate.CalculateDifference(a, b);
            double multiplication = calculate.CalculateMultiplication(a, b);
            double quotient = calculate.CalculateQuotient(a, b);

            Console.WriteLine($"Сумма: {a} + {b} = {sum}");
            Console.WriteLine($"Разность: {a} - {b} = {difference}");
            Console.WriteLine($"Произведение: {a} * {b} = {multiplication}");
            Console.WriteLine($"Частное: {a} / {b} = {quotient}");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option4();
            }
        }

        static void Option5()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("ОБРАБОТКА ОДНОМЕРНОГО МАССИВА");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);

            Console.WriteLine("\nВыполняется функция: Обработка одномерного массива");
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите минимальное значение диапазона: ");
            int minValue = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальное значение диапазона: ");
            int maxValue = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
            }

            Console.WriteLine("Массив значений:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }

            Array array = new Array();
            int min = array.CalculateMinimum(numbers);
            int max = array.CalculateMaximum(numbers);
            double average = array.CalculateAverage(numbers);
            double median = array.CalculateMedian(numbers);
            int numberOfEven = array.CalculateNumberOfEven(numbers);
            int numberOfOdd = array.CalculateNumberOfOdd(numbers);
            int divisibleByTwo = array.SignsOfDivisibilityByTwo(numbers);
            int divisibleByThree = array.SignsOfDivisibilityByThree(numbers);
            int divisibleByFive = array.SignsOfDivisibilityByFive(numbers);
            int divisibleByTen = array.SignsOfDivisibilityByTen(numbers);

            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Среднее: {average}");
            Console.WriteLine($"Медиана: {median}");
            Console.WriteLine($"Количество четных элементов: {numberOfEven}");
            Console.WriteLine($"Количество нечетных элементов: {numberOfOdd}");
            Console.WriteLine($"Количество элементов с признаками делимости на 2: {divisibleByTwo}");
            Console.WriteLine($"Количество элементов с признаками делимости на 3: {divisibleByThree}");
            Console.WriteLine($"Количество элементов с признаками делимости на 5: {divisibleByFive}");
            Console.WriteLine($"Количество элементов с признаками делимости на 10: {divisibleByTen}");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                Option5();
            }
        }

        static void OptionFS()
        {
            Console.Clear();

            Console.ResetColor();
            Console.WriteLine("СПРАВКА");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine(" Справочные сведения по работе с программой");
            Console.SetCursorPosition(1, 6);
            Console.WriteLine(" РАЗДЕЛ МЕНЮ");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine(" ОПИСАНИЕ");
            Console.SetCursorPosition(64, 6);
            Console.WriteLine(" ПАРАМЕТР КОМ. СТРОКИ");
            Console.SetCursorPosition(1, 8);
            Console.WriteLine(" 1. Рассчитать ПЕРВОЕ МАТ... ");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine(" Вычисляет матем. выражение... ");
            Console.SetCursorPosition(64, 8);
            Console.WriteLine(" /1 ");
            Console.SetCursorPosition(1, 10);
            Console.WriteLine(" 2. Рассчитать ВТОРОЕ МАТ... ");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine(" Вычисляет матем. выражение... ");
            Console.SetCursorPosition(64, 10);
            Console.WriteLine(" /2 ");
            Console.SetCursorPosition(1, 12);
            Console.WriteLine(" 3. ПРОТАБУЛИРОВАТЬ ФУНК... ");
            Console.SetCursorPosition(30, 12);
            Console.WriteLine(" Табулирует функцию... ");
            Console.SetCursorPosition(64, 12);
            Console.WriteLine(" /3 ");
            Console.SetCursorPosition(1, 14);
            Console.WriteLine(" 4. КАЛЬКУЛЯТОР ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine(" Выполняет расчет +, -, *, / ");
            Console.SetCursorPosition(64, 14);
            Console.WriteLine(" /4 ");
            Console.SetCursorPosition(1, 16);
            Console.WriteLine(" 5. ОБРАБОТКА ОДНОМЕРНОГО... ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine(" Обрабатывает одномерный массив... ");
            Console.SetCursorPosition(64, 16);
            Console.WriteLine(" /5 ");
            Console.SetCursorPosition(1, 21);
            Console.WriteLine(" Программу разработал НЕНАШЕВ АРТЕМ ДЕНИСОВИЧ | МКМб-22-1 | ТИУ 2024");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            
            Console.SetCursorPosition(0, 24);
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[ESC]");
            Console.ResetColor();
            Console.Write(" - Вернуться в главное меню ");
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                drawMainMenu();
            }
            else
            {
                OptionFS();
            }
        }

        static void OptionExit()
        {
            Environment.Exit(0);
        }

        static void drawMainMenu()
        {
            Console.CursorVisible = true;         
            Console.Clear();
            Console.ResetColor();

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("║                              Лабораторная работа #3                                    ║");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("║                          Создание консольного интерфейса                               ║");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("║                          Выполнил Ненашев Артем Денисович                              ║");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("║                           ТИУ-2024, группа МКМб-22-1                                   ║");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("   ");
            switch (indexItem)
            {
                case 0:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 1:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 2:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 3:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 4:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("4.");
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    break;

                case 5:
                    Console.WriteLine(" МЕНЮ: ");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1.");
                    Console.WriteLine(" Рассчитать первое математическое выражение");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("2.");
                    Console.WriteLine(" Рассчитать второе математическое выражение");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("3.");
                    Console.WriteLine(" Протабулировать функцию на заданном диапозоне");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("4.");
                    Console.ResetColor();
                    Console.WriteLine(" Калькулятор");
                    Console.ResetColor();
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("5.");
                    Console.WriteLine(" Обработка одномерного массива");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" Выберите пункт меню стрелками или нажмите номер пункта [ ] ");

            Console.SetCursorPosition(0, 22);
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.SetCursorPosition(0, 24);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("[F1]");
            Console.ResetColor();
            Console.Write(" - Справка | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("[F10]");
            Console.ResetColor();
            Console.Write(" - Выход   Перемещение:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[СТРЕЛКА ВНИЗ]");
            Console.ResetColor();
            Console.Write(" | ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("[СТРЕЛКА ВВЕРХ]");
            Console.ResetColor();

            Console.SetCursorPosition(57, 15);

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                    Option1();
                    break;

                case ConsoleKey.NumPad2:
                    Option2();
                    break;

                case ConsoleKey.NumPad3:
                    Option3();
                    break;

                case ConsoleKey.NumPad4:
                    Option4();
                    break;

                case ConsoleKey.NumPad5:
                    Option5();
                    break;

                case ConsoleKey.F1:
                    OptionFS();
                    break;

                case ConsoleKey.F10:
                    OptionExit();
                    break;

                default:
                    drawMainMenu();
                    break;

                case ConsoleKey.UpArrow:
                    UpArrow();
                    break;

                case ConsoleKey.DownArrow:
                    DownArrow();
                    break;

                case ConsoleKey.Enter:
                    selectItem();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            Console.SetBufferSize(90, 25);

            foreach (string arg in args)
            {
                if (arg == "\\1")
                {
                    Option1();
                }
                if (arg == "\\2")
                {
                    Option2();
                }
                if (arg == "\\3")
                {
                    Option3();
                }
                if (arg == "\\4")
                {
                    Option4();
                }
                if (arg == "\\5")
                {
                    Option5();
                }
            }

            drawMainMenu();
            Console.ReadKey();
        }
    }
}