// Написать программу которая выводит случайное число.
// из отрезка [10,99] и показывает наибольшую цифру числа.
Console.Clear();
int number=new Random().Next(10,100);//number=78 
int A1 = number/10;//a1=78/10=7
int A2 =number%10;//a2=78%10=8
int max=A1;
if (max < A2)
max=A2;
Console.WriteLine($"максимальная цифра {number } -> {max}");