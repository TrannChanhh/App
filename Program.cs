using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;

namespace C_;

class Program
{
    static void Main(string[] args)
    {
        #region lam quen voi var
        // Console.Write("a:");
        // var a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("b:");
        // var b = Convert.ToInt32(Console.ReadLine());
        
        // Console.WriteLine($"Dien Tich la: {a*b}");
        // Console.WriteLine($"Chu Vi La: {(a+b)*2}");



        // Console.Write("r: ");
        // var r = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"Dien tich hinh tron: {r*r*3.14}");
        // Console.WriteLine($"Chu vi hinh tron: {2*3.14*r}");



        // Console.Write("can nang:");
        // var weight = Convert.ToDouble(Console.ReadLine());
        // Console.Write("chieu cao:");
        // var height = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine($"Chi so co the BMI: {weight/(height*height)}");



        // Console.Write("Your age: ");
        // var age = Convert.ToInt32(Console.ReadLine());
        // if(age >= 18)
        // {
        //     Console.WriteLine("You can watch this movie");
        // }
        // else
        // {
        //     Console.WriteLine("You can't watch this movie");
        // }
        #endregion
        #region 
        // bool gender = false;
        // bool married = true;
        // string name = "Binh";

        // if(gender)
        // {
        //     Console.WriteLine($"Mr.{name}");
        // }
        // else if(married)
        //     {
        //         Console.WriteLine($"Mrs.{name}");
        //     }
        //     else
        //     {
        //        Console.WriteLine($"Ms.{name}"); 
        //     }

        #endregion
        #region giá trị lớn nhất
        // Console.Write("number 1:");
        // var number1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("number 2:");
        // var number2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("number 3:");
        // var number3 = Convert.ToInt32(Console.ReadLine());

        // if(number1 > number2 && number1 > number3)
        // {
        //     Console.WriteLine($"gia tri lon nhat la: {number1}");
        // }
        //  if(number2 > number1 && number2 > number3)
        // {
        //     Console.WriteLine($"gia tri lon nhat la: {number2}");
        // }
        // if(number3 > number1 && number3 > number2)
        // {
        //     Console.WriteLine($"gia tri lon nhat la: {number3}");
        // }
        #endregion
        #region  switch case


        // SWITCH CASE
            // Console.Write("Enter month: ");
            // int month = Convert.ToInt32(Console.ReadLine());
            // switch(month)
            // {
            //     case 1:
            //     case 3:
            //     case 5:
            //     case 7:
            //     case 8:
            //     case 10:
            //     case 12:
            //         Console.Write("31 days");
            //         break;
            //     case 2:
            //         Console.Write("28 or 29 days");
            //         break;
            //     case 6:
            //     case 9:
            //     case 11:  
            //     case 4:
            //         Console.Write("30 days");
            //         break;
            //     default: // ra thông báo nếu nhập ngoài giới hạn
            //         Console.Write("Invalid month");
            //         break;               
            // }
             #endregion
        #region switch case
        // Console.Write("Enter number 1-7: ");
        // int date = Convert.ToInt32(Console.ReadLine());

        // switch(date)
        // {
        //     case 1:
        //         Console.Write("thu 2");
        //         break;
        //     case 2:
        //         Console.Write("thu 3");
        //         break;
        //     case 3:
        //         Console.Write("thu 4");
        //         break;
        //     case 4:
        //         Console.Write("thu 5");
        //         break;
        //     case 5:
        //         Console.Write("thu 6");
        //         break;
        //     case 6:
        //         Console.Write("thu 7");
        //         break;
        //     case 7:
        //         Console.Write("chu nhat");
        //         break;
        //     default:
        //         Console.Write("dot");
        //         break;
        // }
        #endregion
        #region TernaryOperator
        // Console.Write("number 1:");
        // var number1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("number 2:");
        // var number2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("number 3:");
        // var number3 = Convert.ToInt32(Console.ReadLine());

        // Console.Write($"max ={(number1 >  number2 && number1 > number3 ? number1:
        //                             number2 > number1 && number2 > number3 ? number2 : number3)}");
        #endregion
        #region for, while, do while 
        
        // for (int a = 10; a < 19; a += 1)
        // {
        //     Console.WriteLine("Hello guys!");
        // }

        // in ra 20 so nguyen
        // for(int Z  = 1; Z < 21; Z += 1)
        // {
        //     Console.WriteLine($"{Z}");
        // }

        //tinh tong 20 so nguyen
        // int sum = 0;
        // for(int z = 1; z < 21; z++)
        // {
        //     sum += z; 
        // }
        // Console.WriteLine($"tong so nguyen la: {sum}");
        
    
        //hien thi cac so chia het 5  (1-100)
        // int end = 0;

        // for (int n = 1; n <= end ; n++)
        // {
        //     if(n  % 5 == 0)
        //     {
        //         Console.Write(n);
        //     }
        // }

        //hien thi cac so chia het 4  (1-100) lon - nho
        // int end = 0;

        // for (int n = 100; n > end ; n--)
        // {
        //     if(n  % 4 == 0)
        //     {
        //         Console.Write(n);
        //     }
        // }

        // Console.Write("nhap vao mot so: ");
        // var soDuocNhap = Convert.ToInt32(Console.ReadLine());
        // bool check = true;

        // for (int n = 2; n < soDuocNhap; n++)
        // {
        //     if(soDuocNhap % n == 0)
        //     {
        //         check = false;
        //     } 
        // }
        // if(soDuocNhap < 2  || !check)
        // {
        //     Console.WriteLine($"{soDuocNhap} ko la so nguyen to!");
        // } else
        // {
        //     Console.WriteLine($"{soDuocNhap} la so nguyen to!");
        // }
        
        // hien thi cac so chia het 5  (1-100)
        int end = 0;

        for (int n = 0; n <= 100 ; n++)
        {
            if(end == 5)
            {
                if(n % 5 == 0)
                {
                    Console.WriteLine($"{n}");
                    end += 1;
                }
            }
        }
        
        #endregion
    }
        
}