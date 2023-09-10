// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int num = WorkWithUser("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {num} равна {SumOfDigit(num)}");

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int CountDigit(int number)
{
    int count = 0;
    if (number == 0) return 1;
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
void FillDigits(int[] digitsOfNumber, int number)
{
    for (int i = 0; i < digitsOfNumber.Length; i++)
    {
        digitsOfNumber[i] = number % 10;
        number /= 10;
    }
}

int SumOfDigit(int number)
{
    int[] digitsOfNumber = new int[CountDigit(number)]; // Здесь я обратилась к ранее созданному
    // методу определения количества цифр для создания массива с размером - количество
    // цифр в числе
    FillDigits(digitsOfNumber, number); // Здесь заполнила созданный массив цифрами этого числа
    int sum = 0;
    for (int i = 0; i < digitsOfNumber.Length; i++)
    {
        sum += digitsOfNumber[i];
    }
    return sum;
}


