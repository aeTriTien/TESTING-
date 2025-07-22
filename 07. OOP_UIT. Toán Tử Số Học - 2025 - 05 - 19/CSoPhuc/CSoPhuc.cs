using System;
class CSoPhuc
{
    private float Thuc;
    private float Ao;

    public void Nhap()
    {
        Console.WriteLine("Nhap thuc: ");
        Thuc = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap ao: ");
        Ao = float.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Thuc = {0}", Thuc);
        Console.WriteLine("Ao = {0}", Ao);
    }

    public static CSoPhuc operator +(CSoPhuc a, CSoPhuc b)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = a.Thuc + b.Thuc;
        temp.Ao = a.Ao + b.Ao;
        return temp;
    }
    public static CSoPhuc operator -(CSoPhuc a, CSoPhuc b)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = a.Thuc - b.Thuc;
        temp.Ao = a.Ao - b.Ao;
        return temp;
    }
    public static CSoPhuc operator *(CSoPhuc a, CSoPhuc b)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = a.Thuc * b.Thuc - a.Ao * b.Ao;
        temp.Ao = a.Thuc * b.Ao - a.Ao * b.Thuc;
        return temp;
    }
    public static CSoPhuc operator /(CSoPhuc a, CSoPhuc b)
    {
        CSoPhuc temp = new CSoPhuc();
        temp.Thuc = (a.Thuc * b.Thuc + a.Ao * b.Ao) / (a.Ao * a.Ao + b.Ao * b.Ao);
        temp.Ao = (a.Ao * b.Thuc - a.Thuc * b.Ao) / (a.Ao * a.Ao + b.Ao * b.Ao);
        return temp;
    }
}
class ClassMain
{
    static void Main()
    {
        CSoPhuc a = new CSoPhuc();
        CSoPhuc b = new CSoPhuc();

        Console.WriteLine("Nhap so phuc a:");
        a.Nhap();
        Console.WriteLine("Nhap so phuc b:");
        b.Nhap();

        CSoPhuc kq;

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
