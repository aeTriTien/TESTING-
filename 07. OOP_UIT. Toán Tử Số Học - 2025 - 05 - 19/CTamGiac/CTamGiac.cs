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
    public float KhoangCach(CDiem Q)
    {
        return (float)Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y));
    }
}
class CTamGiac
{
    private CDiem A;
    private CDiem B;
    private CDiem C;

    public void Nhap()
    {
        A = new CDiem();
        B = new CDiem();
        C = new CDiem();
        Console.Write("Nhap dinh A: ");
        A.Nhap();
        Console.Write("Nhap dinh B: ");
        B.Nhap();
        Console.Write("Nhap dinh C: ");
        C.Nhap();
    }
    public float Dientich()
    {
        float a = B.KhoangCach(C);
        float b = A.KhoangCach(C);
        float c = A.KhoangCach(B);
        float p = (a + b + c) / 2;
        return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public static bool operator >(CTamGiac a, CTamGiac b)
    {
        return a.Dientich() > b.Dientich();
    }
    public static bool operator <(CTamGiac a, CTamGiac b)
    {
        return a.Dientich() < b.Dientich();
    }
}
class ClassMain
{
    static void Main()
    {
        CTamGiac tg1 = new CTamGiac();
        CTamGiac tg2 = new CTamGiac();

        Console.WriteLine("Nhap tam giac thu nhat:");
        tg1.Nhap();

        Console.WriteLine("Nhap tam giac thu hai:");
        tg2.Nhap();

        Console.WriteLine("\nTam giac co dien tich lon hon la:");
        if (tg1 > tg2)
            Console.WriteLine("Tam giac thu nhat co dien tich lon hon.");
        else if (tg1 < tg2)
            Console.WriteLine("Tam giac thu hai co dien tich lon hon.");
        else
            Console.WriteLine("Hai tam giac co dien tich bang nhau.");
    }
}
