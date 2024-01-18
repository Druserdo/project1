Console.WriteLine("Введите количество мм:");
int mm = int.Parse(Console.ReadLine());
const int ST = 100;
int mmST = mm / ST;
Console.WriteLine($"{mm}мм = {mmST}см");
