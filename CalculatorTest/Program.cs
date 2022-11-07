

u:

Console.Clear();
Console.WriteLine("Введите число Х");
m1: var q = (Console.ReadLine());
Console.Clear();
if (int.TryParse(q, out var t))
{
    
}
else
{
    Console.WriteLine("Некорректный ввод,попробуйте еще раз");
    goto m1;
}
 var x = Convert.ToDouble(q);

m2:  Console.WriteLine("Введите число Y");
    var qq = Console.ReadLine();
Console.Clear();
if (int.TryParse(qq, out var tt))
{

}
else
{
Console.WriteLine("Некорректный ввод,попробуйте еще раз");
goto m2;
}
var y = Convert.ToDouble(qq);

o: m3: Console.WriteLine("Введите номер от 1 до 4 для выполнения следующих действий: 1 - Сложение, 2 - Вычитание 3 - Умножение, 4 - Деление");


    var qqq = Console.ReadLine();
    Console.Clear();
if (int.TryParse(qqq, out var ttt))
{

}
else
{
    Console.WriteLine("Некорректный ввод,попробуйте еще раз");
    goto m3;
}

var z = Convert.ToDouble(qqq);

Double R = 0;
    if (z == 1)
        R = x + y;
    else if (z == 2)
        R = x - y;
    else
    if (z == 3)
        R = x * y;
    else
    if (z == 4)
    {
        if (y == 0)
        {
            Console.WriteLine("На ноль делить нельзя,введите другое число");
            y = Convert.ToDouble(Console.ReadLine());
        }
        R = x / y;
    }
    else
    {
        Console.WriteLine("Выбранного номера не существует, повторите попытку: ");
        goto o;
    }


    Console.WriteLine($"\n\n{R}");
    Console.WriteLine("Хотите выполнить еще операцию? Если да то введите любой текст, если нет, нажмите Enter");
    var p = (Console.ReadLine());
    if (p != "")
        goto u;



