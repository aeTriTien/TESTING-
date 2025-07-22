using System;
class CHonSo
{
    private int Nguyen;
    private int Tu;
    private int Mau;

    public CHonSo(int nguyennguyen, int tutu, int maumau)
    {
        Nguyen = nguyennguyen;
        Tu = tutu;
        Mau = maumau;
    }
    public CHonSo(CHonSo x)
    {
        Nguyen = x.Nguyen;
        Tu = x.Tu;
        Mau = x.Mau;
    }
    public CHonSo()
    {
        Nguyen = 0;
        Tu = 0;
        Mau = 1;
    }
    ~CHonSo()
    {
        return;
    }
}
