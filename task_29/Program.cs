/*Задача 29. Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран. Данные вводятся с консоли пользователем*/


int [] massive = new int [8];
for (int i = 0; i < 8; i ++)
{
    Console.WriteLine($"Введите { i + 1 } ый элемент массива");
    int number = Convert.ToInt32(Console.ReadLine());
    massive[i] = number;
}
Console.WriteLine(String.Join(", ", massive));
