// Задача 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в прмежутке от M до N.
// M=1; N=15 -> 120
// M=4; N=8 -> 30

// ввод числа 
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}

// вывод чисел без рекурсии для проверки
int NumbersFor(int a, int b)
{
    int result = 0;
    for (int i=b; i >=a; i--)
    {
        result += i;
    }
    return result;
}

// вывод чисел с рекурсией
int NumbersRec(int a, int b)
{
    if (a<=b) return NumbersRec(a+1, b)+a;
    else return 0;
}

int n = Promt("Введите число N  :");
int m = Promt("Введите число M  :");
Console.WriteLine("Числа полученные без рекурсии");
Console.WriteLine(NumbersFor(m,n));
Console.WriteLine("Числа полученные с рекурсией");
Console.WriteLine(NumbersRec(m,n));