using System;
class CDonThuc
{
    private float Heso;
    private int Bac;

    public CDonThuc(CDonThuc a)
    {
        Heso = a.Heso;
        Bac = a.Bac;
    }
    public CDonThuc() { }
    public void Nhap()
    {
        Console.Write("Nhap he so: ");
        Heso = int.Parse(Console.ReadLine());
        Console.Write("Nhap bac: ");
        Bac = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine(Heso + "x^" + Bac);
    }
    public static CDonThuc operator +(CDonThuc a, CDonThuc b)
    {
        CDonThuc temp = new CDonThuc();
        temp.Heso = a.Heso + b.Heso;
        temp.Bac = a.Bac;
        return temp;
    }
    public static CDonThuc operator -(CDonThuc a, CDonThuc b)
    {
        CDonThuc temp = new CDonThuc();
        temp.Heso = a.Heso - b.Heso;
        temp.Bac = a.Bac;
        return temp;
    }
    public static CDonThuc operator *(CDonThuc a, CDonThuc b)
    {
        CDonThuc temp = new CDonThuc();
        temp.Heso = a.Heso * b.Heso;
        temp.Bac = a.Bac;
        return temp;
    }
    public static CDonThuc operator /(CDonThuc a, CDonThuc b)
    {
        CDonThuc temp = new CDonThuc();
        temp.Heso = a.Heso / b.Heso;
        temp.Bac = a.Bac;
        return temp;
    }
    public static CDonThuc operator ++(CDonThuc a)
    {
        a.Heso++;
        return a;
    }
    public static bool operator >(CDonThuc a, CDonThuc b)
    {
        return a.Bac > b.Bac;
    }
    public static bool operator <(CDonThuc a, CDonThuc b)
    {
        return a.Bac < b.Bac;
    }
}
class ClassMain
{
    static void Main()
    {
        CDonThuc a = new CDonThuc();
        CDonThuc b = new CDonThuc();

        Console.WriteLine("Nhap don thuc a:");
        a.Nhap();
        Console.WriteLine("Nhap don thuc b:");
        b.Nhap();

        CDonThuc kq;
        kq = a + b;
        Console.WriteLine("Tong:");
        kq.Xuat();

        kq = a - b;
        Console.WriteLine("Hieu:");
        kq.Xuat();

        kq = a * b;
        Console.WriteLine("Tich:");
        kq.Xuat();

        kq = a / b;
        Console.WriteLine("Thuong:");
        kq.Xuat();
    }
}