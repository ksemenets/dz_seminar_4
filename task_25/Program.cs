/* Задача 25: Напишите цикл, который принимает
 на вход два числа (A и B) и возводит число A 
 в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Привет! Давай возведем число в степень!");
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}
int A = ReadNumber("Введи число, которое будем возводить");
int B = ReadNumber("А теперь степень, в которую будем возводить");
int vozvstep(int A, int B)
{
    int res = A;
    
    for(int i = 1; i < B; i++)
        { 
            res = res * A;
        }
        return res;
}
if (A > 0 && B > 0)
{
    int result = vozvstep(A, B);
    Console.WriteLine($"Число {A} в степени {B} равно {result}");
}
else
Console.WriteLine("Оба числа должны быть больше нуля");