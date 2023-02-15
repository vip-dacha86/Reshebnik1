// напишите прорамму которая принимает на вход число и проверяет 
//кратно ли оно одновременно 7 и 23.
//if((a>b||a<c)&&(x>b||x<c)||d==5)
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num%7 == 0 && num%23 == 0)
Console.WriteLine($"{num}->Yes");
else
Console.WriteLine($"{num}->No");