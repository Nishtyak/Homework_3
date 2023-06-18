// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int enter_data ()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void cubes (int N)
{
    double cube = 0;
    for (int i = 1; i <= N; i++)
    {
        cube = Math.Pow(i, 3);
        Console.Write($"{cube} ");
    }
}

int number = enter_data();
cubes(number);

