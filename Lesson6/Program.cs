//int c = (int)new Random().NextDouble();
//Console.WriteLine(c);

////5
//string myPerson = "Viktor\nOduew";
//Console.WriteLine(myPerson);
////6
//string myString = "284";
//Console.WriteLine(int.Parse(myString));
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int a = number/1000;
Console.WriteLine(a);
int b = number % 1000 / 100;
Console.WriteLine(b);
int c = number % 100 / 10;
Console.WriteLine(c);
int d = number % 10;
Console.WriteLine(d);
Console.WriteLine($"сумма цифр: {a + b + c + d}");
Console.WriteLine($"Произведение цифр: {a * b * c * d}");