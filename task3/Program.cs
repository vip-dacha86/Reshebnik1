// Показать все целые числа от -N до N
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int y = x;
x = -x;
while(x <=y)
{
    Console.Write(x+",");
x++; // X=X+1;
}

