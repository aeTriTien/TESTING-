using System;

class Program
{
    static void Main()
    {
        CPhanSo a = new CPhanSo();
        CPhanSo b = new CPhanSo();

        Console.WriteLine("Nhap phan so a:");
        a.Nhap();
        Console.WriteLine("Nhap phan so b:");
        b.Nhap();

        Console.WriteLine("\nPhan so a: ");
        a.Xuat();
        Console.WriteLine("Phan so b: ");
        b.Xuat();

        Console.WriteLine($"\nGia tri a = {a.getGiaTri()}");
        Console.WriteLine($"Gia tri b = {b.getGiaTri()}");

        Console.WriteLine("\nThay doi Tu va Mau cua a:");
        a.setTu(5);
        a.setMau(10);
        a.Xuat();
        Console.WriteLine($"Tu = {a.getTu()}, Mau = {a.getMau()}");

        Console.WriteLine("\nKhoi tao lai a bang (7, 9):");
        a.KhoiTao(7, 9);
        a.Xuat();

        Console.WriteLine("\nSao chep b vao a:");
        a.KhoiTao(b);
        a.Xuat();

        Console.WriteLine($"\na == b: {a == b}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a > b: {a > b}");
        Console.WriteLine($"a < b: {a < b}");
        Console.WriteLine($"a >= b: {a >= b}");
        Console.WriteLine($"a <= b: {a <= b}");

        Console.WriteLine("\nTong a + b:");
        (a + b).Xuat();

        Console.WriteLine("Hieu a - b:");
        (a - b).Xuat();

        Console.WriteLine("Tich a * b:");
        (a * b).Xuat();

        Console.WriteLine("Thuong a / b:");
        (a / b).Xuat();

        Console.WriteLine("Luy thua a^3:");
        (a ^ 3).Xuat();

        Console.WriteLine("\nCac ham xu ly rieng:");
        Console.Write("Tong(a, b) = "); 
        a.Tong(b).Xuat();
        Console.Write("Hieu(a, b) = "); 
        a.Hieu(b).Xuat();
        Console.Write("Tich(a, b) = "); 
        a.Tich(b).Xuat();
        Console.Write("Thuong(a, b) = "); 
        a.Thuong(b).Xuat();

        Console.WriteLine("\n++a:");
        (++a).Xuat();

        Console.WriteLine("--b:");
        (--b).Xuat();

        Console.WriteLine("\nKiem tra:");
        Console.WriteLine($"a co nghia: {a.ktCoNghia()}");
        Console.WriteLine($"a toi gian: {a.ktToiGian()}");
        Console.WriteLine($"a la so duong: {a.ktDuong()}");
        Console.WriteLine($"a la so am: {a.ktAm()}");
        Console.WriteLine($"a la so khong: {a.ktKhong()}");
        Console.WriteLine($"Dau cua a: {a.XetDau()}");


    }
}
