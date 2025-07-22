using System;
class CDiem
{
    private float x;
    private float y;
    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());

    }
    public void Xuat()
    {
        Console.WriteLine("x= {0}", x);
        Console.WriteLine("y= {0}", y);
    }
    public double KhoangCach(CDiem Q)
    {
        return Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y));
    }
    public static bool operator >(CDiem a, CDiem b)
    {
        CDiem Goc = new CDiem();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 > d2;
    }
    public static bool operator <(CDiem a, CDiem b)
    {
        CDiem Goc = new CDiem();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 < d2;
    }
    public static bool operator >=(CDiem a, CDiem b)
    {
        CDiem Goc = new CDiem();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 >= d2;
    }
    public static bool operator <=(CDiem a, CDiem b)
    {
        CDiem Goc = new CDiem();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 <= d2;
    }
}
class ClassMain
{
    static void Main()
    {
        CDiem a = new CDiem();
        CDiem b = new CDiem();

        Console.WriteLine("Nhap diem thu nhat: ");
        a.Nhap();
        Console.WriteLine("Nhap diem thu hai: ");
        b.Nhap();

        Console.WriteLine("Diem lon nhat la: ");
        if (a > b)
            a.Xuat();
        else
            b.Xuat();
    }
}