using System;
class CNgay
{
    private int Ngay;
    private int Thang;
    private int Nam;

    public CNgay(int ngayngay, int thangthang, int namnam)
    {
        Ngay = ngayngay;
        Thang = thangthang;
        Nam = namnam;
    }
    public CNgay(CNgay x)
    {
        Ngay = x.Ngay;
        Thang = x.Thang;
        Nam = x.Nam;
    }
    public CNgay()
    {
        Ngay = 1;
        Thang = 1;
        Nam = 1;
    }
    ~CNgay() { }
}