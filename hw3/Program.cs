// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int str = UserData("Введите кол-во строк");
int column = UserData("Введите кол-во столбцов массива: ");
int[,] array = (GetArray(str, column, 10, 20));
PrintArray(array);
Averege(array, str, column);

void Averege(int[,] array, int str, int column)
 {
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j,i];
        }
        System.Console.WriteLine($"Среднее арифметическое в {i + 1} столбце = {Math.Round(sum / str, 2)}");
        sum = 0;
    }
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива
void PrintArray(int[,] array)
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

// ----------------Опрос пользователя по массиву
int UserData(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine());
}