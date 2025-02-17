using System;
class Program
{
    private static void Main(string[] args)
    {
        /*  Console.OutputEncoding = System.Text.Encoding.UTF8;
          Console.Write("nhap ho va ten cua ban: ");
          string ten = (Console.ReadLine();
          Console.WriteLine("chao ban {0}", ten);
          Console.ReadKey();
    */
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhap so thu nhat: ");
        double sothunhat = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so thu Hai: ");
        double sothuhai = Convert.ToDouble(Console.ReadLine());
        double tong = sothunhat = sothuhai;
        Console.WriteLine("Tong so la: " + tong);
        Console.WriteLine(" Tong hai so {o} + {1} = {2}", sothunhat, sothuhai, tong);
    }
}
