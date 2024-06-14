static void Main()
{
    Console.WriteLine(Введите число для проверки на четность:);
    int number = Convert.ToInt32(Console.ReadLine());

    if (IsEven(number))
    {
        Console.WriteLine(Число четное);
    }
    else
    {
        Console.WriteLine(Число нечетное);
    }

    Console.WriteLine(Введите два числа для сложения:);
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = Add(num1, num2);
    Console.WriteLine($Сумма чисел: {sum});

    Console.WriteLine(Введите число для вычисления факториала:);
    int factorialNumber = Convert.ToInt32(Console.ReadLine());
    long factorial = CalculateFactorial(factorialNumber);
    Console.WriteLine($Факториал числа {factorialNumber}: {factorial});
}
