Start();
void Start()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        
        
        int numTask = SetNumber("Введите номер задачи");
        
        switch (numTask)
        {
            case 0: return; 
            case 25: MyPow(); break;
            case 27: SumNumbers(); break;
            case 29: ViewArray(); break;
            default: Console.WriteLine("Error"); break;
        }
        Console.WriteLine("Задача выполнена, нажмите любую клавишу");
        Console.ReadKey();
    }
}
int SetNumber(string comment)
{
    Console.Write($" {comment}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
void MyPow()
{
    Console.Clear();
    int num = SetNumber("число A");
    int degree = SetNumber("число B");

    Console.WriteLine($"{num} в степени {degree} = {Pow(num, degree)}");
}

int Pow(int num, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= num;
    }
    return result;
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

void SumNumbers()
{
    Console.Clear();
    int num = SetNumber("Введите число N");
    Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
}

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void ViewArray()
{
    Console.Clear();
    int size = SetNumber("Введите size");
    int minValue = SetNumber("Введите minValue");
    int maxValue = SetNumber("Введите maxValue");
    int[] array = GetRandomArray(size, minValue, maxValue);
    Console.WriteLine($"[{String.Join(",", array)}]");
}
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
