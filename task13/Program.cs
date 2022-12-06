/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

System.Console.WriteLine("Введите число:");
string enternum = Console.ReadLine();
int numb = Convert.ToInt32(enternum);

if ((numb < 100) && (numb > -100))                                              // проверяем, является ли число двузначным
{
    Console.WriteLine("Введенное число двузначное, третьей цифры нет.");        // является
}                                                   
else                                                                            // не является, заходим сюда                            
{
    if (numb < 0)                                                               // если число отрицательное, то учитываем минус
        Console.WriteLine(enternum[3]);                                     
    else  
        Console.WriteLine(enternum[2]);
}

