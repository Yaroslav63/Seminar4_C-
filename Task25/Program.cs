Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int a = number1;
int b = number2;
System.Console.WriteLine($"{a}^{b} = " + Math.Pow(a, b));
