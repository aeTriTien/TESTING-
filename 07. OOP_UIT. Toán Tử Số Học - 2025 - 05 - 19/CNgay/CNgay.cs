using System;
class CNgay
{
    private int Ngay;
    private int Thang;
    private int Nam;
    public void Nhap()
    {
        Console.Write("Nhap ngay: ");
        Ngay = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        Thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        Nam = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ngay: {0}", Ngay);
        Console.WriteLine("Thang: {0}", Thang);
        Console.WriteLine("Nam: {0}", Nam);
    }
    public static bool operator >(CNgay a, CNgay b)
    {
        if (a.Nam != b.Nam)
            return a.Nam > b.Nam;
        if (a.Thang != b.Thang)
            return a.Thang > b.Thang;
        if (a.Ngay != b.Ngay)
            return a.Ngay > b.Ngay;
        return false;
    }
    public static bool operator <(CNgay a, CNgay b)
    {
        if (a.Nam != b.Nam)
            return a.Nam < b.Nam;
        if (a.Thang != b.Thang)
            return a.Thang < b.Thang;
        if (a.Ngay != b.Ngay)
            return a.Ngay < b.Ngay;
        return false;
    }
}
class ClassMain
{
    static void Main()
    {
        CNgay a = new CNgay();
        CNgay b = new CNgay();

        Console.WriteLine("Nhap ngay thu nhat:");
        a.Nhap();

        Console.WriteLine("Nhap ngay thu hai:");
        b.Nhap();

        Console.WriteLine("\nNgay lon hon la:");
        if (a > b)
            a.Xuat();
        else if (a < b)
            b.Xuat();
        else
            Console.WriteLine("Hai ngay bang nhau.");
    }
}
