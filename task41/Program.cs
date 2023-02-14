/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Write("Enter numbers separated by commas: ");
string[] strArray = Console.ReadLine().Split(',');

int count = 0;

int[] result = new int[strArray.Length];

for (int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(strArray[i]);
    if (result[i] > 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"User entered {count} numbers greather than 0");
