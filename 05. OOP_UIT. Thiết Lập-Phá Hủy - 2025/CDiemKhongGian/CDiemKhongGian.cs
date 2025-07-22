using System;
class CDiemKhongGian
{
    private int x;
    private int y;
    private int z;

    public CDiemKhongGian(int xx, int yy, int zz)
    {
        x = xx;
        y = yy;
        z = zz;
    }
    public CDiemKhongGian(CDiemKhongGian a)
    {
        x = a.x;
        y = a.y;
        z = a.z;
    }
    public CDiemKhongGian()
    {
        x = 0;
        y = 0;
        z = 0;
    }
    ~CDiemKhongGian()
    {
        return;
    }
}
