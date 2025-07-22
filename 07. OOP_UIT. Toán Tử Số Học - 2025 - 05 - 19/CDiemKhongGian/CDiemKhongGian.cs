using System;
class CDiemKhongGian
{
    private float x;
    private float y;
    private float z;
    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
        Console.Write("Nhap z: ");
        z = float.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("x= {0}", x);
        Console.WriteLine("y= {0}", y);
        Console.WriteLine("z= {0}", z);
    }
    public double KhoangCach(CDiemKhongGian Q)
    {
        return Math.Sqrt((x - Q.x) * (x - Q.x) + (y - Q.y) * (y - Q.y) + (z - Q.z) * (z - Q.z));
    }
    public static bool operator >(CDiemKhongGian a, CDiemKhongGian b)
    {
        CDiemKhongGian Goc = new CDiemKhongGian();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 > d2;
    }
    public static bool operator <(CDiemKhongGian a, CDiemKhongGian b)
    {
        CDiemKhongGian Goc = new CDiemKhongGian();
        double d1 = Goc.KhoangCach(a);
        double d2 = Goc.KhoangCach(b);
        return d1 < d2;
    }
}
class ClassMain
{
    static void Main()
    {
        CDiemKhongGian a = new CDiemKhongGian();
        CDiemKhongGian b = new CDiemKhongGian();

        Console.WriteLine("Nhap diem thu nhat:");
        a.Nhap();

        Console.WriteLine("Nhap diem thu hai:");
        b.Nhap();

        Console.WriteLine("\nDiem xa goc toa do hon la:");
        if (a > b)
            a.Xuat();
        else if (a < b)
            b.Xuat();
        else
            Console.WriteLine("Hai diem cach goc toa do bang nhau.");
    }
}
