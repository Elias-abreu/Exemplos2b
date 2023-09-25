
using System;

public class Datas
{
    public Datas()
    {
        DateTime d1 = DateTime.Now;
        Console.WriteLine(d1);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(d1.DayOfYear);

        DateTime d2 = new DateTime(2023, 07, 24, 13, 50, 30);
        Console.WriteLine(d2);
        Console.WriteLine($"D2 é {d2.ToLongDateString()}");


        Console.WriteLine("TimeSpan");
        TimeSpan ts = new TimeSpan(13, 50, 30);
        Console.WriteLine(ts);

        TimeSpan ts2 = TimeSpan.FromDays(1.5);
        Console.WriteLine(ts2);

        DateTime d3 = new DateTime(1992, 07, 30);

        TimeSpan tms = DateTime.Now.Subtract(d3);
        Console.WriteLine(tms);
        Console.WriteLine($"Idade é {tms.Days/365}");


        DateTime dt = DateTime.Parse("1992-07-22");
        Console.WriteLine(dt);
        Console.WriteLine(dt.ToUniversalTime());

        DateTime dd = DateTime.Parse("24 / 07 / 2023");
        Console.WriteLine(dd.Year);

        DateOnly dto = new DateOnly(2023, 07, 24);
        Console.WriteLine(dto);
        Console.WriteLine(dto.DayOfWeek);
    }
}
