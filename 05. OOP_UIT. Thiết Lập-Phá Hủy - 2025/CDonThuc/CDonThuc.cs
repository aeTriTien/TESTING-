using System;
class CDonThuc
{
    private int Heso;
    private int Somu;

    public CDonThuc(int xx, int yy)
    {
        Heso = xx;
        Somu = yy;
    }
    public CDonThuc(CDonThuc a)
    {
        Heso = a.Heso;
        Somu = a.Somu;
    }
    public CDonThuc()
    {
        Heso = 0;
        Somu = 0;
    }
    ~CDonThuc() { }
}