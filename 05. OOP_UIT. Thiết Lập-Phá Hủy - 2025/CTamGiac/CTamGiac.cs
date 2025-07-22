using System;
class CDiem
{
    private int x;
    private int y;

    public CDiem(int xx, int yy)
    {
        x = xx;
        y = yy;
    }
    public CDiem(CDiem a)
    {
        x = a.x;
        y = a.y;
    }
    public CDiem()
    {
        x = 0;
        y = 0;
    }
    ~CDiem()
    {
        return;
    }
}
class CTamGiac
{
    private CDiem a;
    private CDiem b;
    private CDiem c;

    public CTamGiac(CDiem aa, CDiem bb, CDiem cc)
    {
        a = aa;
        b = bb;
        c = cc;
    }
    public CTamGiac(CTamGiac tg)
    {
        a = tg.a;
        b = tg.b;
        c = tg.c;
    }
    public CTamGiac()
    {
        a = new CDiem();
        b = new CDiem();
        c = new CDiem();
    }
    ~CTamGiac() { }
}
class Classmain
{
    static void Main()
    {
        CTamGiac c = new CTamGiac();
    }
}