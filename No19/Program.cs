// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 12321
int GetNumber (string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if(int.TryParse(ValueFromConsole, out int num))
        {
            if ((num > 9999) && (num < 100000))
                return num;
            else
            {
                Console.WriteLine("Вы ввели не пятизначное число. Повторите попытку!");
            }
        }
        else 
        {
            Console.WriteLine("вы ввели не число. Нужно ввести пятизначное число.");
        }
    }
}

string PalindromCheck (string die_zahl)
{
    if ((die_zahl[0] == die_zahl[4]) && (die_zahl[1] == die_zahl[3]))
    {
        string res = "Число является палиндромом";
        return res;
    }
    else 
    {
        string anti_res = "Число не является палиндромом";
        return anti_res;
    }
}

string message = "Введите пятизначное число: ";
int number = GetNumber(message);
string die_zahl = Convert.ToString(number);
string result = PalindromCheck(die_zahl);
Console.WriteLine(result);