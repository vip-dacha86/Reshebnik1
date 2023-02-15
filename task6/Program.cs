// Написать программу которая будет принимать на вход 2 числа и определяет является ли второе число кратным первому,
//если второе число не кратно топрограмма выводит остаток деления.
// 34,5-> не кратно остаток 4
//16,4-> кратно .
Console.Clear
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2=int.Parse(Console.ReadLine());
if (num2 % num1 == 0){
    Console.WriteLine("кратно");}
else{
    Console.WriteLine($"не кратно,остаток={num2 % num1}");
}