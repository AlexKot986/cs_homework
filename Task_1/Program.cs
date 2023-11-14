// Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, 
// введенные из командной строки, и выводящую результат выполнения на экран.


using System.Text.RegularExpressions;

Console.WriteLine("Введите выражение");
string? s = Console.ReadLine();
Regex regex = new(@"\d[*/+-]{1}\d");

if (regex.IsMatch(s.Replace(" ", "")) && s is not null)
{
    Console.Write(s + " = ");

    if (s.Contains('+')) 
    {
        string[] st = s.Replace(" ", "").Split('+').ToArray();
        Console.WriteLine(int.Parse(st[0]) + int.Parse(st[1]));

    }
    if (s.Contains('-')) 
    {
        string[] st = s.Replace(" ", "").Split('-').ToArray();
        Console.WriteLine(int.Parse(st[0]) - int.Parse(st[1]));

    }
    if (s.Contains('*')) 
    {
        string[] st = s.Replace(" ", "").Split('*').ToArray();
        Console.WriteLine(int.Parse(st[0]) * int.Parse(st[1]));

    }
    if (s.Contains('/')) 
    {
        string[] st = s.Replace(" ", "").Split('/').ToArray();
        Console.WriteLine(int.Parse(st[0]) / int.Parse(st[1]));

    }
}
else Console.WriteLine("Неверный формат!");

