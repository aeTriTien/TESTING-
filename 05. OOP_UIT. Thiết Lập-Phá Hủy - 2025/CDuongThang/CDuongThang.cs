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
class CDuongThang
{
    private CDiem a;
    private CDiem b;

    public CDuongThang(CDiem aa, CDiem bb)
    {
        a = aa;
        b = bb;
    }
    public CDuongThang(CDuongThang d)
    {
        a = d.a;
        b = d.b;
    }
    public CDuongThang()
    {
        a = new CDiem();
        b = new CDiem();
    }
    ~CDuongThang() { }
}