// Напишите программу которая принимает на вход два числа ипроверяетявляется ли одно число квадратом другого
// 5,25->Yes 4,16->yes  25,5->yes 8,9->no  
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a*a==b || Math.Pow(b,2) ==a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}