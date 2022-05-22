// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

int GetNumber (string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string ValueFromConsole = Console.ReadLine();
        if(int.TryParse(ValueFromConsole, out int num))
        {
            if(num > 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Вы ввели не натуральное число. Попробуйте еще раз!");
            }
        }
       else
        {
            Console.WriteLine("Вы ввели не число, пожалуйста, введите натуральное число!");
        }
    } 
}

void CubeWriter (double N)
{
    double count = 1;
    System.Console.Write($"{N} -> ");
    do
    {
        double cube = Math.Pow(count, 3);
        System.Console.Write(cube + ", ");
        count ++;
    } 
    while (N > count);
    if (N == count)
    {
        double lastcube = Math.Pow(count, 3);
        System.Console.Write(lastcube + ".");
    }
}

// 1 4 -> write 1, -> 2 4 -> write 1, 8, -> 3 4 -> write 1, 8, 27, -> 4 4 -> write 1, 8, 27, 64. 

// другой вариант, но мне не нравится пунктуация void CubeCalculator(int N)
// {
//     Console.Write($"{N} -> ");
//     foreach(int num in Enumerable.Range(1,N))
//     System.Console.Write($"{num * num * num}, ");
// }

string message = "Введите натуральное число: ";
double N = GetNumber(message);
CubeWriter(N);