Console.WriteLine("Введите число:");
string userNum = Console.ReadLine()!;
int intNum;

if (int.TryParse(userNum, out intNum)) // проверяем, является ли введенная строка int-ом
{
    userNum = userNum.TrimStart('-','0'); // убираем в начале введенной строки минус и нули
    if (userNum.Length < 3) Console.WriteLine("Третьей цифры в числе " + intNum + " нет!"); // проверка на 3 разряда в числе
    else Console.WriteLine("Третья цифра числа " + intNum + ": " + userNum[2]); // вывод третьего разряда введенного числа
}
else Console.WriteLine("Введено не число типа int!"); // результат проверки - ввели не число