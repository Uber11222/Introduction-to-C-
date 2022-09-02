Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);
int max = 0;
if (a>b) {
    max = a;
}
else {
    max = b;
}
if (c>max) {
    max = c;
}
else {
    max =max;
}
Console.WriteLine("Максимальное число {0}", max);