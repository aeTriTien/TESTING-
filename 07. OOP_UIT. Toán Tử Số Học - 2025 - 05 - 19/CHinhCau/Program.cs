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
}
class CHinhCau
{
    private CDiemKhongGian I;
    private float R;

    public void Nhap()
    {
        I = new CDiemKhongGian();
        Console.WriteLine("Nhap tam hinh cau: ");
        I.Nhap();
        Console.WriteLine("Nhap ban kinh: ");
        R = float.Parse(Console.ReadLine());
    }
    public float DienTich()
    {
        return 3.14f * R * R;
    }
    public static bool operator >(CHinhCau a, CHinhCau b)
    {
        return a.DienTich() > b.DienTich();
    }
    public static bool operator <(CHinhCau a, CHinhCau b)
    {
        return a.DienTich() < b.DienTich();
    }
}
class ClassMain
{
    static void Main()
    {
        CHinhCau h1 = new CHinhCau();
        CHinhCau h2 = new CHinhCau();

        Console.WriteLine("Nhap hinh cau thu nhat:");
        h1.Nhap();

        Console.WriteLine("Nhap hinh cau thu hai:");
        h2.Nhap();

        Console.WriteLine("\nSo sanh dien tich:");
        if (h1 > h2)
            Console.WriteLine("Hinh cau thu nhat co dien tich lon hon.");
        else if (h1 < h2)
            Console.WriteLine("Hinh cau thu hai co dien tich lon hon.");
        else
            Console.WriteLine("Hai hinh cau co dien tich bang nhau.");
    }
}
