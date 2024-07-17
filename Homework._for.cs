using System.Diagnostics.CodeAnalysis;

namespace Homework;


class For_While_DoWhile
{
    static void Main (String[]agrs) 
    {
        #region cau 1 Hien thi 20 so nguyen dau tien

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
        #region cau 2 Tinh tong 20 so nguyen dau tien

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
        #region cau 3 Hien thi cac so %5 [1-100]

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
        #region cau 4 Hien thi cac so %4 [1-100] lon - nho

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
        #region cau 5 Kiem tra so nguyen to

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
        #region cau 6 Hien thi 5 so %5 dau tien [1-100]

        //while
        // int i = 100;
        // int end = 0;
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
        // do 
        // {
        //     if(i % 5 == 0 && end < 5)
        //     {
        //         Console.Write(i + " ");
        //     }
        //     end++;
        //     i += 5;
        // } while (i <= 400);
        #endregion
        #region Hien thi so nguyen to [100-1000]

        // int number = 101;
        
        // while (number <= 1000)
        // {   
        //     bool check = true;
        //     for (int i = 2; i <= Math.Sqrt(number); i++)
        //     {
        //         if (number % i == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //     } 
        //     if (check)
        //         {
        //         Console.Write($"{number} ");
        //         }
        //     number += 2;
        // }


        // int number = 101;
        
        // do 
        // {   
        //     bool check = true;
        //     for (int i = 2; i <= Math.Sqrt(number); i++)
        //     {
        //         if (number % i == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //     }
        //     if (check)
        //     {
        //         Console.Write($"{number} ");
        //     }
        //     number += 2;
        // } while (number <= 1000);
        
        
        //cách khác
        // int number = 101;
        
        // while (number <= 1000)
        // {   
        //     bool check = true;
        //     int i = 2;
        //     while (i <= Math.Sqrt(number))
        //     {
        //         if (number % i == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //         i++;
        //     }
        //     if (check)
        //         {
        //         Console.Write($"{number} ");
        //         }
        //     number += 2;
        // }


        int number = 101;
        
        do 
        {   
            bool check = true;
            int i = 2;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
                {
                Console.Write($"{number} ");
                }
            number += 2; 
        } while (number <= 1000);

        #endregion
    
    
    }
}