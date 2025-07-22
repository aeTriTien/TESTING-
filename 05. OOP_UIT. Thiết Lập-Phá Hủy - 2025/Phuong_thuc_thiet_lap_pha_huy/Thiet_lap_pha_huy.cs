using System;
class CPhanSo
{
    private int Tu;
    private int Mau;

    public CPhanSo(int TuTu, int MauMau)
    {
        Tu = TuTu;
        Mau = MauMau;
    }
    public CPhanSo(CPhanSo x)
    {
        Tu = x.Tu;
        Mau = x.Mau;
    }
    public CPhanSo()
    {
        Tu = 0;
        Mau = 1;
    }
    ~CPhanSo()
    {
        return;
    }
}
