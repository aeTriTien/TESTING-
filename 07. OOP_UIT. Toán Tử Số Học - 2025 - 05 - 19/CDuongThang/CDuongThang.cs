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
}
class CDuongThang
{
    private CDiem a;
    private CDiem b;

    public void Nhap()
    {
        a = new CDiem();
        b = new CDiem();
        Console.WriteLine("Nhap diem a: ");
        a.Nhap();

        Console.WriteLine("Nhap diem b: ");
        b.Nhap();
    }
    public static bool operator >(CDuongThang P, CDuongThang Q)
    {
        double d1 = P.a.KhoangCach(P.b);
        double d2 = Q.a.KhoangCach(Q.b);
        return d1 > d2;
    }
    public static bool operator <(CDuongThang P, CDuongThang Q)
    {
        double d1 = P.a.KhoangCach(P.b);
        double d2 = Q.a.KhoangCach(Q.b);
        return d1 < d2;
    }
}
class ClassMain
{
    static void Main()
    {
        CDuongThang d1 = new CDuongThang();
        CDuongThang d2 = new CDuongThang();

        Console.WriteLine("Nhap duong thang thu nhat:");
        d1.Nhap();

        Console.WriteLine("Nhap duong thang thu hai:");
        d2.Nhap();

        Console.WriteLine("\nDuong thang co do dai lon hon la:");
        if (d1 > d2)
            Console.WriteLine("Duong thang thu nhat dai hon.");
        else if (d1 < d2)
            Console.WriteLine("Duong thang thu hai dai hon.");
        else
            Console.WriteLine("Hai duong thang co do dai bang nhau.");
    }
}