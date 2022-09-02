Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
if (a>b) {
    Console.WriteLine("Большее {0}, меньшее {1}", a, b);
}
else {
    Console.WriteLine("Большее {1}, меньшее {0}", a, b);
}