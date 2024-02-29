Console.WriteLine("podaj pierwsza liczbe:");
double liczba1 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj druga liczbe:");
double liczba2 = double.Parse(Console.ReadLine());
Console.WriteLine("podaj trzecia liczbe:");
double liczba3 = double.Parse(Console.ReadLine());

if (liczba1 > liczba2 && liczba1 > liczba3)
{
    Console.WriteLine($"{liczba1} jest najwieksza z podanych");
}
else if (liczba2 > liczba1 && liczba2 > liczba3)
{
    Console.WriteLine($"{liczba2} jest najwieksza z podanych");
}
else if (liczba3>liczba1&&liczba3>liczba2)
{
    Console.WriteLine($"{liczba3} jest najwieksza z podanych");
}
else if (liczba1 == liczba2 && liczba1 > liczba3  )
{
    Console.WriteLine($"{liczba1} i {liczba2} to najwieksze podane liczby");
}
else if(liczba1 == liczba3&& liczba1>liczba2)
{
    Console.WriteLine($"{liczba1} i {liczba3} to najwieksze podane liczby");
}
else if (liczba2 == liczba3 && liczba2 > liczba1)
{
    Console.WriteLine($"{liczba2} i {liczba3} to najwieksze podane liczby");
}
else if (liczba1 == liczba2||liczba1 == liczba3||liczba2==liczba3)
{
    Console.WriteLine("wszystkie liczby sa sabie rowne");
}