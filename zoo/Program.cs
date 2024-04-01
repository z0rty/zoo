class Calculator
{
    // Метод сложения
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Метод вычитания
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Метод умножения
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    // Метод деления
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль!");
            return 0;
        }
        return (double)a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выйти из программы");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
                break;

            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                Console.WriteLine("Результат сложения: " + calculator.Add(num1, num2));
            else if (choice == 2)
                Console.WriteLine("Результат вычитания: " + calculator.Subtract(num1, num2));
            else if (choice == 3)
                Console.WriteLine("Результат умножения: " + calculator.Multiply(num1, num2));
            else if (choice == 4)
                Console.WriteLine("Результат деления: " + calculator.Divide(num1, num2));
            else
                Console.WriteLine("Некорректный выбор операции");

            Console.WriteLine("Желаете выполнить еще одну операцию? (да/нет)");
            if (Console.ReadLine().ToLower() != "да")
                break;
        }
    }
}