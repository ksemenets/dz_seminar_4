/*Задача 27:
 Напишите программу, которая принимает на вход число
  и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}

//создаем метод, который складывает все цифры из полученного выше числа
int getsumma(int number)
{
int sum = 0;
    while(number > 0)
    {
    sum = sum + number % 10;
    number = number / 10;    
    }
    return sum;
}
int number = ReadNumber("Введите число "); //объявляем переменную, вызывая метод
if (number < 0)
{
    number = number * (-1);
}
int summa = getsumma(number); 
Console.WriteLine("Сумма всех цифр этого числа равна:" + summa);

