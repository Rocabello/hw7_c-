// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), 
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, 
// а также какое число стоит на этом месте или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет



Console.Clear();
int num1 = UserData("Введите кол-во строк массива: ");
int num2 = UserData("Введите кол-во столбцов массива: ");
int[,] array = (GetArray(num1, num2, 10, 20));
PrintArray(array);
int str = UserDataStrColunms("Введите строку искомого элемента: ");
int column = UserDataStrColunms("Введите столбец искомого элемента: ");
CheckElement(array, str, column);


//-----------------Поиск элемента
void CheckElement(int[,] array, int m, int n)

{
    if (m < array.GetLength(0) || n < array.GetLength(1))
        Console.WriteLine($"{m} , {n} -> Искомый элемент: {array[m, n]}");

    else Console.WriteLine($"{m} , {n} -> такого числа в массиве нет");
}

// -----------------Ввод искомого элемента
int UserDataStrColunms(string message)
{
    System.Console.WriteLine($"{message}");
    int Element = int.Parse(Console.ReadLine());
    return Element - 1;
}


// ----------------Опрос пользователя по массиву
int UserData(string message)
{
    System.Console.WriteLine($"{message}");
    return int.Parse(Console.ReadLine());
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


