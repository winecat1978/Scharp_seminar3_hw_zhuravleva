// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int GetDot(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string coordinate = Console.ReadLine();
        if (int.TryParse(coordinate, out int num))
        {
            return num;
        }
        else 
        {
            Console.WriteLine("Вы ввели не число, введите число.");
        }
    }
}

double LengthCalculator(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
  double difX = Math.Pow((Bx-Ax),2);
  double difY = Math.Pow((By-Ay),2);
  double difZ = Math.Pow((Bz-Az),2);
  double res = Math.Sqrt(difX + difY + difZ);

    return res;
}


string messageA_x = "Введите координату x точки А: ";
string messageA_y = "Введите координату y точки А: ";
string messageA_z = "Введите координату z точки А: ";

string messageB_x = "Введите координату x точки B: ";
string messageB_y = "Введите координату y точки B: ";
string messageB_z = "Введите координату z точки B: ";

int Ax = GetDot(messageA_x);
int Ay = GetDot(messageA_y);
int Az = GetDot(messageA_z);

int Bx = GetDot(messageB_x);
int By = GetDot(messageB_y);
int Bz = GetDot(messageB_z);

double result = LengthCalculator(Ax, Ay, Az, Bx, By, Bz);

Console.WriteLine($"Расстояние между точками А({Ax};{Ay};{Az}) и В({Bx};{By};{Bz}) равно {result}.");