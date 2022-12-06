

/*  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

System.Console.WriteLine("ВВедите цифру от 1 до 7 включительно:");
string enternum = Console.ReadLine();
int numb = Convert.ToInt32(enternum);

if (numb<1 || numb>7) System.Console.WriteLine("Введенное число не соответствует ни одному из дней недели");  
else
{
    if ((numb == 7)||(numb == 6))
    {
        System.Console.WriteLine("Да");   
    }
    else
    {
        System.Console.WriteLine("нет"); 
    }
}