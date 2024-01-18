//a
Console.WriteLine("Введите количество мм:");
int mm1 = int.Parse(Console.ReadLine());
const int ST = 100;
int mmST = mm1 / ST;
Console.WriteLine($"{mm1}мм = {mmST}см");
//b
Console.WriteLine("Введите количество мм:");
int mm2 = int.Parse(Console.ReadLine());
const int m = 1000;
int mm_m= mm2 / m;
Console.WriteLine($"{mm2}мм = {mm_m}м");
//c
Console.WriteLine("Введите количество мм:");
int mm3 = int.Parse(Console.ReadLine());
const int km = 100000;
int mm_km = mm3 / km;
Console.WriteLine($"{mm3}мм = {mm_km}км");
//d
Console.WriteLine("Введите количество мм:");
int mm4 = int.Parse(Console.ReadLine());
const int mile = 160900;
int mm_mile = mm4 / mile;
Console.WriteLine($"{mm4}мм = {mm_mile}мили");
//e
Console.WriteLine("Введите количество мм:");
int mm5 = int.Parse(Console.ReadLine());
const int yard = 914;
int mm_yard = mm5 /yard;
Console.WriteLine($"{mm5}мм = {mm_yard}см");
