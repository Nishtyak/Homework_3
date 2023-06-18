// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int enter_data ()
{
    Console.Write("Введите число пятизначное: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

string palindrome_5 (int num)
{
    int[] figures = new int [5];
    for(int i = 0; i < 5; i++)
    {
        figures[i] = num % 10;
        num = num / 10;
    }
    if(figures[0] == figures[4] && figures[1] == figures[3]) return "Да";
    else return "Нет";
}

int number = enter_data();
if(number < 10000 || number > 99999) Console.Write("Неправильное число!");
else Console.Write(palindrome_5(number));