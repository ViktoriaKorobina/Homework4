// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = WorkWithUser("Введите основание степени: ");
int b = WorkWithUser("Введите степень: ");
int degreeResult = Degree(a, b);
Console.WriteLine($"{a}^{b} = {degreeResult}");

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Degree(int degreeTitle, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++) // Здесь счетчик начинается с 1, так как число
    // в нулевой степени это 1, а resalt уже равен единице, и в цикл for заходить в таком случае не нужно.
    {
        result *= degreeTitle;
    }
    return result;
}