// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.Clear();
int num1 = UserData("Введите кол-во строк: ");
int num2 = UserData("Введите кол-во столбцов: ");
PrintArray(GetArray(num1,num2,10,20));


// ----------------Опрос пользователя
int UserData(string message)
{
    System.Console.WriteLine($"{message}");
        return Convert.ToInt32(Console.ReadLine());
}

// ----------------Заполнение массива
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2);
        }
    }
    return res;
}

// -----------------Вывод массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
