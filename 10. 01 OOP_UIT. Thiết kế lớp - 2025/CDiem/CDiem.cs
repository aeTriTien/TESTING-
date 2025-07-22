using System;

public class CDiem
{
    private float x;
    private float y;

    public CDiem()
    {
        x = 0;
        y = 0;
    }

    public CDiem(CDiem P)
    {
        x = P.x;
        y = P.y;
    }


    public CDiem(float xx, float yy)
    {
        x = xx;
        y = yy;
    }

    public CDiem(float xx)
    {
        x = xx;
        y = 0;
    }

    public void KhoiTao()
    {
        x = 0;
        y = 0;
    }

    public void KhoiTao(CDiem P)
    {
        x = P.x;
        y = P.y;
    }

    public void KhoiTao(float xx, float yy)
    {
        x = xx;
        y = yy;
    }

    public void KhoiTao(float xx)
    {
        x = xx;
        y = 0;
    }

    public void Nhap()
    {
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("(" + x + "," + y + ")");
    }

    public float getX()
    {
        return x;
    }

    public float getY()
    {
        return y;
    }

    public void setX(float xx)
    {
        x = xx;
    }

    public void setY(float yy)
    {
        y = yy;
    }

    public bool ktTrungGoc()
    {
        if (x == 0 && y == 0)
            return true;
        return false;
    }

    public bool ktThuocHoanh()
    {
        if (y == 0)
            return true;
        return false;
    }

    public bool ktThuocTung()
    {
        if (x == 0)
            return true;
        return false;
    }

    public bool ktTrung(CDiem P)
    {
        if (x == P.x && y == P.y)
            return true;
        return false;
    }

    public bool ktKoTrung(CDiem P)
    {
        if (!(x == P.x && y == P.y))
            return true;
        return false;
    }

    public float KhoangCachGoc()
    {
        return (float)Math.Sqrt(x * x + y * y);
    }


    public float KhoangCachHoanh()
    {
        return Math.Abs(y);
    }

    public float KhoangCachTung()
    {
        return Math.Abs(x);
    }

    public float KhoangCach(CDiem P)
    {
        return (float)Math.Sqrt((x - P.x) * (x - P.x) + (y - P.y) * (y - P.y));
    }

    public float KhoangCachX(CDiem P)
    {
        return Math.Abs(x - P.x);
    }

    public float KhoangCachY(CDiem P)
    {
        return Math.Abs(y - P.y);
    }
    public CDiem DoiXungGoc()
    {
        return new CDiem(-x, -y);
    }

    public CDiem DoiXungHoanh()
    {
        return new CDiem(x, -y);
    }

    public CDiem DoiXungTung()
    {
        return new CDiem(-x, y);
    }

    ~CDiem()
    {
        return;
    }

    public static CDiem operator +(CDiem A, CDiem B)
    => new CDiem(A.x + B.x, A.y + B.y);


    public static CDiem operator -(CDiem A, CDiem B)
    => new CDiem(A.x - B.x, A.y - B.y);

    public static CDiem operator *(CDiem A, CDiem B)
    => new CDiem(A.x * B.x , A.y * B.y);

    public static bool operator ==(CDiem A, CDiem B)
    {
        return A.KhoangCachGoc() == B.KhoangCachGoc();
    }

    public static bool operator !=(CDiem A, CDiem B)
    {
        return !(A == B);
    }

    public static bool operator >(CDiem A, CDiem B)
    {
        return A.KhoangCachGoc() > B.KhoangCachGoc();
    }

    public static bool operator <(CDiem A, CDiem B)
    {
        return A.KhoangCachGoc() < B.KhoangCachGoc();
    }

    public static bool operator >=(CDiem A, CDiem B)
    {
        return A.KhoangCachGoc() >= B.KhoangCachGoc();
    }

    public static bool operator <=(CDiem A, CDiem B)
    {
        return A.KhoangCachGoc() <= B.KhoangCachGoc();
    }
    public override bool Equals(object obj)
    {
        return this == obj as CDiem;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() ^ y.GetHashCode();
    }
}
