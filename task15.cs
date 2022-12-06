Console.WriteLine("Введите номер дня недели:");
string userNum = Console.ReadLine()!;
int intNum;

if (int.TryParse(userNum, out intNum)) // проверяем, является ли введенная строка int-ом
{
    if (intNum > 0 && intNum <= 7)
    {        
        if (intNum > 5) Console.WriteLine("Выходной день!"); // 6 и 7 - выходные
        else Console.WriteLine("Рабочий день!"); // 1-5 - рабочие
    }
    else Console.WriteLine("День недели с номером " + intNum + " не существует!"); // результат проверки - ввели не число от 1 до 7
}
else Console.WriteLine("Введено не число типа int!"); // результат проверки - ввели не число