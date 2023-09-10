// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

string[] digitsOfTerminal = WorkWithUser("Введите цифры через запятую или через пробел: ");
// Пожалуйста вводите числа через запятую без пробела или без запятой с пробелом. С двумя разделителями справиться не смогла.
// там, когда два разделителя идут следом друг за другом образуется пустая строка.
// И вот эту пустую строку в число не преобразовать, как я поняла. Возникает ошибка. 
int[] digitsOfConvert = DigitOfString(digitsOfTerminal);
PrintArray(digitsOfConvert);


string[] WorkWithUser(string message) // Вводим строку, состоящую из цифр с разделителями
{
    Console.Write(message);
    string str = Console.ReadLine();
    string[] symb = str.Split(',', ' ');// Два типа разделителей.
    // Но все ломается, когда они идут друг за другом.
    // Программа работает только когда цифры разделяются либо запятой, либо пробелом.
    return symb;
}
int[] DigitOfString(string[] symbs)// Преобразует строковый массив в целочисленный
{
    int[] digits = new int[symbs.Length];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = int.Parse(symbs[i]);
    }
    return digits;
}
void PrintArray(int[] array)//Выводит массив на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}