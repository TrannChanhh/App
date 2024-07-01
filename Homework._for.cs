using System.Diagnostics.CodeAnalysis;

namespace Homework;


class For_While_DoWhile
{
    static void Main (String[]agrs) 
    {
        #region cau 1

        //while
        // int i = 1;
        // while (i <= 20)
        // {
        //     Console.Write(i + " ");
        //     i++;
        // } 

        //do-while
        // int i = 1;
        // do 
        // {
        //     Console.Write(i + " ");
        //     i++;
        // } while(i <= 20);

        #endregion
        #region cau 2

        //while 
        // int sum = 0;
        // int i = 1;
        // while (i <= 20)
        // {
        //     sum += i;
        //     i++;
        // }
        // Console.Write($"Tong 20 so nguyen: {sum}");

        //do_while 
        // int sum = 0;
        // int i = 0;
        // do 
        // {
        //     sum += i;
        //     i++;
        // } while (i <= 20);
        // Console.Write($"Tong la: {sum}");

        #endregion
        #region cau 3

        //while
        // int i = 0;
        // int end = 100;
        // while (i <= end)
        // {
        //     if(i % 5 == 0)
        //     {
        //         Console.Write(i + " "); 
        //     }       
        //    i += 5;
        // }
        
        //do_while
        // do
        // {
        //     Console.Write(i + " ");
        //     i += 5;
        // } while (i <= end);

        #endregion
        #region cau 4

        //while
        // int i = 100;
        // int end = 0;
        // while (i > end)
        // {
        //     if(i % 4 == 0)
        //     {
        //         Console.Write(i + " ");  
        //     }
        //     i--;
        // }

        //do_while
        // do
        // {
        //     if(i % 4 == 0)
        //     {
        //         Console.Write(i + " ");
        //     }
        //     i--;
        // } while (i > end);
        #endregion
        #region cau 5

        //while
        // Console.Write("Nhap vao so bat ky:");
        // var soNhap = Convert.ToInt32(Console.ReadLine());
        // int n = 2;
        // bool check = true;

        // while (n < soNhap)
        // {
        //     if(soNhap % n == 0)
        //     {
        //         check = false;
        //     }
        //     n ++;
        // } if (soNhap < 2 || !check)
        // {
        //     Console.WriteLine($"{soNhap} ko la so nguyen to!");
        // } else
        // {
        //     Console.WriteLine($"{soNhap} la so nguyen to!");
        // }

        //do_while
        // do 
        // {
        //     if(soNhap % n == 0)
        //     {
        //         check = false;
        //     }
        //     n++;
        // } while (n < soNhap);
        // if(soNhap < 2 || !check)
        //     {
        //         Console.WriteLine($"{soNhap} ko la so nguyen to!");
        //     } else
        //     {
        //         Console.WriteLine($"{soNhap} la so nguyen to!");
        //     }
        #endregion
        #region cau 6

        //while
        int i = 100;
        int end = 0;
        // while (i <= 400)
        // {
        //     if(i % 5 == 0  && end < 5)
        //     {
        //         Console.Write(i + " "); 
        //     }    
        //     end += 1;   
        //     i += 5;
        // }

        //do_while
        do 
        {
            if(i % 5 == 0 && end < 5)
            {
                Console.Write(i + " ");
            }
            end++;
            i += 5;
        } while (i <= 400);
        #endregion


    }
}