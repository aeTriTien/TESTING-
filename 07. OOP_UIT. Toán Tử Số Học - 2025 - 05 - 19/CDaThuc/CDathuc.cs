using System;
class CDaThuc
{
    private float []Heso;
    private int Bac;
    public CDaThuc(int bac)
    {
        Heso = new float[bac + 1];
        Bac = bac;
    }
    public CDaThuc()
    {
        Heso = new float[0];
        Bac = 0;
    }
    public void Nhap()
    {
        Console.Write("Nhap bac: ");
        Bac = int.Parse(Console.ReadLine());
        Heso = new float[Bac + 1];
        for (int i = 0; i <= Bac; i++)
        {
            Console.Write("Nhap he so bac" + i + ": ");
            Heso[i] = int.Parse(Console.ReadLine());
        }
    }
    public void Xuat()
    {
        for (int i=Bac; i>=0; i--)
        {
            if (Heso[i] > 0)
                Console.Write("+");
            Console.Write(Heso[i] + "x^" + i);
        }    
    }
    public static CDaThuc operator +(CDaThuc a, CDaThuc b)
    {
        int maxBac = Math.Max(a.Bac, b.Bac);
        CDaThuc temp = new CDaThuc(maxBac);
        for (int i=0; i<=maxBac; i++)
        {
            float x = 0, y = 0;
            if (a.Bac >= i)
                x = a.Heso[0];
            if (b.Bac >= i)
                y = b.Heso[i];
            temp.Heso[i] = x + y;
        }
        return temp;
    }
    public static CDaThuc operator -(CDaThuc a, CDaThuc b)
    {
        int maxBac = Math.Max(a.Bac, b.Bac);
        CDaThuc temp = new CDaThuc(maxBac);
        for (int i = 0; i <= maxBac; i++)
        {
            float x = 0, y = 0;
            if (a.Bac >= i)
                x = a.Heso[0];
            if (b.Bac >= i)
                y = b.Heso[i];
            temp.Heso[i] = x - y;
        }
        return temp;
    }
    public static CDaThuc operator *(CDaThuc a, CDaThuc b)
    {
        CDaThuc temp = new CDaThuc(a.Bac + b.Bac);
        for (int i = 0; i <= a.Bac; i++)
        {
            for(int j =0; j<=b.Bac; j++)
            {
                temp.Heso[i + j] = a.Heso[i] * b.Heso[j];
            }
        }
        return temp;
    }

}
class ClassMain
{
    static void Main()
    {
        CDaThuc a = new CDaThuc();
        CDaThuc b = new CDaThuc();

        Console.WriteLine("Nhap da thuc a: ");
        a.Nhap();
        Console.WriteLine("Nhap da thuc b: ");
        b.Nhap();

        CDaThuc kq = new CDaThuc();
        kq = a + b;
        Console.WriteLine("\nTong: ");
        kq.Xuat();

        kq = a - b;
        Console.WriteLine("\nHieu: ");
        kq.Xuat();

        kq = a * b;
        Console.WriteLine("\nTich: ");
        kq.Xuat();
    }
}