Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (a%2 == 0) {
   Console.WriteLine("Чётное ли число {0}: да", a);
}
else {
   Console.WriteLine("Чётное ли число {0}: нет", a);
}