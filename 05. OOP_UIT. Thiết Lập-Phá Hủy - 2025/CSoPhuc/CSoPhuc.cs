using System;
class CSoPhuc
{
    private int Thuc;
    private int Ao;

    public CSoPhuc(int thucthuc, int aoao)
    {
        Thuc = thucthuc;
        Ao = aoao;
    }
    public CSoPhuc(CSoPhuc x)
    {
        Thuc = x.Thuc;
        Ao = x.Ao;
    }
    public CSoPhuc()
    {
        Thuc = 0;
        Ao = 0;
    }
    ~CSoPhuc(){}
}