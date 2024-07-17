namespace Method;

class Method
{
    static void Main(string[] args)
    {
        // soNguyen(2, 10);
        Console.Write("Nhap n: ");
        int n = soNhap();
        CreateArray(n);
    }
    #region 
    // static void soNguyen()
    // {   

    //     int i = 1;
    //     while (i <= 10)
    //     {
    //         Console.Write(i + " ");
    //         i++;
    //     }
    // }

    // static void soNguyen()
    // {   
    //     Console.Write("Nhap 1 so: ");
    //     int soNhap = Convert.ToInt32(Console.ReadLine());
            
    //         int i = 1;
    //         while (i <= soNhap)
    //     {
    //         Console.Write(i + " ");
    //         i++;
    //     }

    // }

    //  static void soNguyen(int n, int m)
    // {
    //     if (n < m)
    //     {
    //         for (int i = n; i <= m; i++)
    //         {
    //             Console.WriteLine(i);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Error!");
    //     }
    // }
    
    #endregion
    static void CreateArray(int n)
    {   
        Random random = new Random();
        int[] array = new int[n];

        for (int i = 0; i <= array.Length; i++)
        {   
            array[i] = random.Next(1,10);
            Console.Write($"{array[i]} ");
        }
    }
    
    static int soNhap()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
}