// решение для случайного положительного трехзначного числа
//int number = new Random().Next(100,1000); 
//int secondDigit;
//string answer;
//secondDigit = (number / 10) % 10;
//answer = "Вторая цифра в числе " + number + ": " + secondDigit;
//Console.WriteLine(answer);

// решение для числа от пользователя
Console.WriteLine("Введите трехзначное число:");
string userNum = Console.ReadLine()!;
int intNum;

if (int.TryParse(userNum, out intNum)) // проверяем, является ли введенная строка int-ом
{
    userNum = userNum.TrimStart('-','0'); // убираем в начале введенной строки минус и нули
    if (userNum.Length != 3) Console.WriteLine("Число " + intNum + " не явялется трехзначным!"); // проверка на трехзначность
    else Console.WriteLine("Вторая цифра числа " + intNum + ": " + userNum[1]); // вывод второго разряда введенного числа
}
else Console.WriteLine("Введено не число типа int!"); // результат проверки - ввели не число