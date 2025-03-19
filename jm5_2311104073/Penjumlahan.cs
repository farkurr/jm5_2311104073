using System;

class Program
{
    static void Main()
    {
        // Gunakan tiga digit dari NIM, misalnya 12, 34, dan 56
        int angka1 = 12;
        int angka2 = 34;
        int angka3 = 56;

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return a + b + c;
    }
}
