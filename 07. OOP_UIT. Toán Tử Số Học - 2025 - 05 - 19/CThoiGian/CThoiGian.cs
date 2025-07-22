using System;
class CThoiGian
{
    private int Gio;
    private int Phut;
    private int Giay;

    public void Nhap()
    {
        Console.Write("Nhap gio: ");
        Gio = int.Parse(Console.ReadLine());

        Console.Write("Nhap phut: ");
        Phut = int.Parse(Console.ReadLine());

        Console.Write("Nhap giay: ");
        Giay = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Gio: {0}", Gio);
        Console.WriteLine("Phut: {0}", Phut);
        Console.WriteLine("Giay: {0}", Giay);
    }
    public static bool operator >(CThoiGian a, CThoiGian b)
    {
        if (a.Gio != b.Gio)
            return a.Gio > b.Gio;
        if (a.Phut != b.Phut)
            return a.Phut > b.Phut;
        if (a.Giay > b.Giay)
            return a.Giay > b.Giay;
        return false;
    }
    public static bool operator <(CThoiGian a, CThoiGian b)
    {
        if (a.Gio != b.Gio)
            return a.Gio < b.Gio;
        if (a.Phut != b.Phut)
            return a.Phut < b.Phut;
        if (a.Giay > b.Giay)
            return a.Giay < b.Giay;
        return false;
    }
}
class ClassMain
{
    static void Main()
    {
        CThoiGian a = new CThoiGian();
        CThoiGian b = new CThoiGian();

        Console.WriteLine("Nhap thoi gian thu nhat:");
        a.Nhap();

        Console.WriteLine("Nhap thoi gian thu hai:");
        b.Nhap();

        Console.WriteLine("\nThoi gian lon hon la:");
        if (a > b)
            a.Xuat();
        else if (a < b)
            b.Xuat();
        else
            Console.WriteLine("Hai thoi gian bang nhau.");
    }
}
