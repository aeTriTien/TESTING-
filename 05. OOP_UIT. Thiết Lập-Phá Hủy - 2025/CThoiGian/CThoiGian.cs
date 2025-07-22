using System;
class CThoiGian
{
    private int Gio;
    private int Phut;
    private int Giay;

    public CThoiGian(int giogio, int phutphut, int giaygiay)
    {
        Gio = giogio;
        Phut = phutphut;
        Giay = giaygiay;
    }
    public CThoiGian(CThoiGian x)
    {
        Gio = x.Gio;
        Phut = x.Phut;
        Giay = x.Giay;
    }
    public CThoiGian()
    {
        Gio = 0;
        Phut = 0;
        Giay = 0;
    }
    ~CThoiGian() { }
}