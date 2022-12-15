//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
/*
int ReadInt(string number)
{
    Console.WriteLine(number);
    return int.Parse(Console.ReadLine());
}

int A = ReadInt("Input number A: ");
int B = ReadInt("Input number B: ");
Exponentiation(A, B);

void Exponentiation(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 
 /*
int number = ReadInt("Введите число: ");

int count = MethodOfCountingDigitsInNumber(number);

MethodOfDisplayingSumOfDigitsInNumber(number, count);

int ReadInt(string number)
{
    Console.Write(number);
    return int.Parse(Console.ReadLine());
}

int MethodOfCountingDigitsInNumber(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void MethodOfDisplayingSumOfDigitsInNumber (int n, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum = n % 10 + sum;
        n = n / 10;
    }
    Console.WriteLine(sum);
}
*/
    
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
/*
int[] NewArray()
{
Console.Write("Input number of digit in array:\t");
int numbers = Convert.ToInt32(Console.ReadLine());

int[] array = new int[numbers];

for (int i = 0; i < array.Length; i++)
    {
    Console.Write($"\n Введите число для заполнения массива {i}:\t");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine("[{0}]", string.Join(", ", array));
return array;
}
 int[] resalt = NewArray();
/*
 