/*
Zadacha1. Найти сумму всех натуральных от 1 до заданного.
int GetSum(int num)
{
  int sum = 0;
  for(int current =1; current <= num; current++)
   sum += current;
  return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(GetSum(a));
*/
/*
//Zadacha2. Посчитать кол-во цифр в числе.
int Number(int num)
{
  int count = 0;

  while (num != 0)
  {
    num = num / 10;
    count++;
  }
  return count;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int count = Number(a);
Console.WriteLine(count);
*/
/*
//Zadacha3. Генерация массива случ числами
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue + 1);
   
   return array;
}

void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
*/
/*
//MyrepozCSDz004.
//Zadacha1. Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Метод возведения в степень
void ToExpon(int numbA, int numbB)
{
    int result = 1;
    for (int i = 1; i <= numbB; i++)
    {
        result = result * numbA;
    }
    Console.WriteLine(result);
}
Console.Write("Input a number A: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int numbB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A in exp B equals: " ); 
ToExpon(numbA, numbB);
*/

/*
//Zadacha2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Метод подсчета цифр в числе.
int NumberSize(int num)
{
  int count = 0;

  while (num != 0)
  {
    num = num / 10;
    count++;
  }
  return count;
}
// Метод вывода суммы цифр в числе.
void SumNumbers(int n, int size)
{
   int sum = 0;
   for (int i = 1; i <= size; i++)
   {
     sum += n % 10;
     n /= 10;
   }
   Console.WriteLine(sum);
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int size = NumberSize(a);
Console.WriteLine($"Sum all digits in the number is equals:  " );
SumNumbers(a, size);
*/
/*
//Zadacha3. Nesmog. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.Write("Input a size number: ");
int s = Convert.ToInt32(Console.ReadLine());
int size = s;
int[] CreateArray(int size)
{
   int[] array = new int[size];
   
   for(int i = 0; i < size; i++)
   {

    Console.Write($"Input a {i+1} element: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    
   }
     return array; 
}

void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " " );

   Console.WriteLine();
}

int[] newArray = CreateArray(size);
ShowArray(newArray);
*/
//Gotovo!
