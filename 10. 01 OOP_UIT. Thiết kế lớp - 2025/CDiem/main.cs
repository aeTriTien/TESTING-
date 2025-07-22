using System;

public class Program
{
    public static int MinhHoaCDiem()
    {
        // === NHÓM KHỞI TẠO ===

        // Nhập
        CDiem A = new CDiem();
        Console.Write("\nNhap doi tuong A: ");
        A.Nhap();
        Console.WriteLine("\nDia chi cua A: " + A.GetHashCode());
        Console.Write("\nThong tin doi tuong A: "); A.Xuat();

        // Constructor kiểu nhập
        CDiem B = new CDiem();
        Console.Write("\nNhap doi tuong B: ");
        B.Nhap();
        Console.WriteLine("\nDia chi cua B: " + B.GetHashCode());
        Console.Write("\nThong tin doi tuong B: "); B.Xuat();

        // Constructor mặc định
        CDiem C = new CDiem();
        Console.WriteLine("\nDia chi cua C: " + C.GetHashCode());
        Console.Write("\nThong tin doi tuong C: "); C.Xuat();

        // Constructor sao chép
        CDiem D = new CDiem(C);
        Console.WriteLine("\nDia chi cua D: " + D.GetHashCode());
        Console.Write("\nThong tin doi tuong D: "); D.Xuat();

        // Constructor đầy đủ
        CDiem E = new CDiem(1.1f, 2.2f);
        Console.WriteLine("\nDia chi cua E: " + E.GetHashCode());
        Console.Write("\nThong tin doi tuong E: "); E.Xuat();

        // Constructor 2 tham số
        CDiem F = new CDiem(4.4f, 5.5f);
        Console.WriteLine("\nDia chi cua F: " + F.GetHashCode());
        Console.Write("\nThong tin doi tuong F: "); F.Xuat();

        // Constructor 1 tham số
        CDiem G = new CDiem(6.6f);
        Console.WriteLine("\nDia chi cua G: " + G.GetHashCode());
        Console.Write("\nThong tin doi tuong G: "); G.Xuat();

        // KhoiTao mặc định
        CDiem H = new CDiem();
        H.KhoiTao();
        Console.WriteLine("\nDia chi cua H: " + H.GetHashCode());
        Console.Write("\nThong tin doi tuong H: "); H.Xuat();

        // KhoiTao sao chép
        CDiem I = new CDiem();
        I.KhoiTao(E);
        Console.WriteLine("\nDia chi cua I: " + I.GetHashCode());
        Console.Write("\nThong tin doi tuong I: "); I.Xuat();

        // KhoiTao 3 tham số
        CDiem J = new CDiem();
        J.KhoiTao(7.7f, 8.8f);
        Console.WriteLine("\nDia chi cua J: " + J.GetHashCode());
        Console.Write("\nThong tin doi tuong J: "); J.Xuat();

        // KhoiTao 2 tham số
        CDiem K = new CDiem();
        K.KhoiTao(10.1f, 11.2f);
        Console.WriteLine("\nDia chi cua K: " + K.GetHashCode());
        Console.Write("\nThong tin doi tuong K: "); K.Xuat();

        // KhoiTao 1 tham số
        CDiem L = new CDiem();
        L.KhoiTao(12.3f);
        Console.WriteLine("\nDia chi cua L: " + L.GetHashCode());
        Console.Write("\nThong tin doi tuong L: "); L.Xuat();

        // === NHÓM CUNG CẤP THÔNG TIN ===

        Console.WriteLine("\nHoanh do cua L: " + L.getX());
        Console.WriteLine("\nTung do cua L: " + L.getY());

        CDiem M = new CDiem(1, 2);
        Console.WriteLine("\nDia chi cua M: " + M.GetHashCode());
        Console.Write("\nThong tin doi tuong M: "); M.Xuat();

        // === NHÓM CẬP NHẬT THÔNG TIN ===
        CDiem O = new CDiem();
        O.setX(9.9f);
        O.setY(8.8f);
        Console.WriteLine("\nDia chi cua O: " + O.GetHashCode());
        Console.Write("\nThong tin doi tuong O: "); O.Xuat();

        // === NHÓM KIỂM TRA ===

        CDiem P = new CDiem(1, 2);
        CDiem Q = new CDiem(4, 5);
        Console.WriteLine("\nP > Q?  " + (P > Q));
        Console.WriteLine("\nP < Q?  " + (P < Q));
        Console.WriteLine("\nP >= Q? " + (P >= Q));
        Console.WriteLine("\nP <= Q? " + (P <= Q));

        CDiem R = new CDiem(0, 0);
        CDiem S = new CDiem(5, 0);
        CDiem T = new CDiem(0, 6);
        Console.WriteLine("\nR trung goc? " + R.ktTrungGoc());
        Console.WriteLine("\nS thuoc truc hoanh? " + S.ktThuocHoanh());
        Console.WriteLine("\nT thuoc truc tung? " + T.ktThuocTung());

        CDiem Y = new CDiem(9, 8);
        CDiem Z = new CDiem(9, 8);
        Console.WriteLine("\nY trung Z? " + Y.ktTrung(Z));
        Console.WriteLine("\nY khong trung Z? " + Y.ktKoTrung(Z));

        // === NHÓM XỬ LÝ ===

        CDiem AA = new CDiem(1, 2);
        CDiem AB = new CDiem(4, 5);
        CDiem AC = AA + AB;
        Console.Write("\nThong tin doi tuong AC (AA + AB): "); AC.Xuat();
        AA += AB;
        Console.Write("\nThong tin doi tuong AA sau += AB: "); AA.Xuat();

        CDiem AD = AA - AB;
        Console.Write("\nThong tin doi tuong AD (AA - AB): "); AD.Xuat();
        AA -= AB;
        Console.Write("\nThong tin doi tuong AA sau -= AB: "); AA.Xuat();

        CDiem dot = AB * AB;
        Console.WriteLine("\nTich vo huong AB * AB = " + dot);

        Console.WriteLine("\nKhoang cach AB den goc toa do: " + AB.KhoangCachGoc());

        Console.WriteLine("\nKhoang cach AB den AC: " + AB.KhoangCach(AC));
        Console.WriteLine("\nKhoang cach X theo Ox: " + AB.KhoangCachX(AC));
        Console.WriteLine("\nKhoang cach Y theo Oy: " + AB.KhoangCachY(AC));

        CDiem AE = AB.DoiXungGoc();
        Console.Write("\nDoi xung AB qua goc: "); AE.Xuat();

        CDiem AF = AB.DoiXungHoanh();
        Console.Write("\nDoi xung AB qua truc hoanh: "); AF.Xuat();

        CDiem AG = AB.DoiXungTung();
        Console.Write("\nDoi xung AB qua truc tung: "); AG.Xuat();

        return 0;
    }

    public static void Main()
    {
        MinhHoaCDiem();
    }
}