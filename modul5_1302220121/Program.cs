internal class Program
{
    public class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic x1 = angka1;
            dynamic x2 = angka2;
            dynamic x3 = angka3;
            return x1 + x2 + x3;
        }
    }
    private static void Main(string[] args)
    {
        float a = 13;
        float b = 02;
        float c = 22;
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<float>(a, b, c));

    }
}