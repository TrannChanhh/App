using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
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
        // int end = 0;

        // for (int n = 0; n <= 100 ; n++)
        // {
        //     if(end == 5)
        //     {
        //         if(n % 5 == 0)
        //         {
        //             Console.WriteLine($"{n}");
        //             end += 1;
        //         }
        //     }
        // }

        #endregion
        #region NestedLoop

        // Ve hcn 10x15
        //row = 10
        // element = 15 *

        //for
        // int rows = 10, elements = 15;
        // for (int row = 1; row <= rows; row++)
        // {   
        //     Console.Write($"{row}\t");  //   \t = tab,  \n = new line
        //     for (int element = 1; element <= elements; element++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.Write("\n");
        // }

        //while
        // int rows = 10, elements = 15;
        // int row = 1;
        // while (row <= rows)
        // {
        //     Console.Write($"{row}\t");
        //     int element = 1;
        //     while (element <= elements)
        //     {
        //         Console.Write("*");
        //         element++;
        //     }
        //     Console.Write("\n");
        //     row++;
        // }

        //hcn rong
        // int rows = 10, elements = 15;
        // for (int row = 1; row <= rows; row++)
        // {
        //     Console.Write($"{row}\t");
        //     for (int element = 1; element <= elements; element++)
        //     {
        //         if (row == 1 || row == rows || element == 1 || element == elements)
        //         {
        //             Console.Write($"*");
        //         } else 
        //         {
        //             Console.Write($" ");
        //         }
        //     }
        //     Console.Write("\n");
        // }

        //do_while

        //    do 
        //     {
        //          Console.Write($"{row}\t");
        //          int element =1;
        //          do
        //          {
        //             Console.Write("*");
        //             element++;
        //          }
        //         while(element<=elements) ;
        //          Console.Write("\n");
        //              row++;
        //     }
        //     while(row<= rows);
        //     Console.WriteLine();


        //Ve hinh tam giac 
        // int rows = 10;
        // int elements = 1;
        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < elements; j++)
        //     {
        //         Console.Write("*" + " ");
        //     }
        //     elements++;
        //     Console.Write("\n");
        // }

        //cach 2
        // int rows = 10;
        // int columns = 10;

        // for (int i = 1; i <= rows; i++)
        //     {
        //         for (int j = 1; j<=columns; j++)
        //         {
        //             // In ký tự '*' ở đầu hàng, cuối hàng và đường chéo
        //             //if (j == 1 || j == i || i == rows)
        //             if(j <= i)
        //             {
        //                 Console.Write("*");
        //             }
        //             else
        //             {
        //                 Console.Write("");
        //             }
        //         }
        //         Console.WriteLine();
        //     }

        //Bang cuu chuong
        // int number;

        // do
        // {
        //     Console.Write("Enter number 2 - 9: ");
        //     number = Convert.ToInt32(Console.ReadLine());
        //     int.TryParse(Console.ReadLine(), out number);  // thử chuyển đổi kiểu dữ liệu
        // } while (number < 2 || number > 9);
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"{number} x {i} = {number * i}");
        // }



        // for (int i = 1; i <= 10; i++)
        // {   
        //     for (int number = 2; number <= 9; number++)
        //     {   

        //         Console.Write($"{number} x {i} = {number * i}\t");

        //     }
        //     Console.WriteLine();
        // }

        //Hien thi so nguyen to 100-1000


        // for (int number = 101; number <= 1000; number += 2)
        // {   
        //     bool check  = true;
        //     for(int j = 2; j <= Math.Sqrt(number); j++)
        //     {
        //         if(number % j == 0)
        //         {
        //             check = false;
        //             break;
        //         }
        //     }
        //     if(check)
        //     {
        //         Console.Write($"{number} ");
        //     }
        // }


        #endregion
        #region Array

        //tao mang so nguyen
        // phai xac dinh truoc so phan tu
        //cách 1:
        // int[] numberLists = new int[5]; //index = 0-4
        // Console.WriteLine(numberLists[0]); // lenh ktra gia tri trong array

        // string[] jobLists = new string[3]; // tùy vào kiểu dữ liệu mà giá trị nó sẽ hiện thị khác nhau
        // Console.WriteLine(numberLists[0]);

        // bool[] genderLists = new bool[5]; // kiểu bool auto trả giá trị là false
        // Console.WriteLine(genderLists[0]);

        //cách 2: Tạo và gán giá trị ban đầu
        // int[] numberLists = { 12, 4, 5 };
        // for (int n = 0; n < numberLists.Length; n++)
        // {
        //     Console.WriteLine($"vi tri{n} - {numberLists[n]}");
        // }


        //Hien thi ten 5 nguoi
        // string[] studentLists = {"Chanh", "Huy", "Tan", "Quan", "Anh"};  //
        // for (int stt = 0; stt < studentLists.Length; stt++)
        // {
        //     Console.WriteLine($"STT {stt} - Ten {studentLists[stt]}");
        // }

        // int[] soNguyen = new int[10] {12,1,2,3,4,5,6,7,8,9};

        // for (int i = 0; i < soNguyen.Length; i++)
        // {   

        //     Console.Write("Nhap so nguyen: ");
        //     soNguyen[i] = int.Parse(Console.ReadLine());
        // }
        // for (int stt = 0; stt < soNguyen.Length; stt++)
        // {
        //     Console.Write($"{soNguyen[stt]}" + " ");
        // }

        //tao mang 10pt, yc user nhap 10 gia tri diem, hien thi diem lon nhat va diem nho nhat
        // double[] Points = new double[10];
        // Console.WriteLine("Nhap diem: ");

        // for (int i = 0; i < Points.Length; i++)
        // {   
        //     Points[i] = double.Parse(Console.ReadLine());
        // }
        // Console.Write("Toan bo diem: " + "\n");
        // for (int stt = 0; stt < Points.Length; stt++)
        // {
        //     Console.Write($"{Points[stt]}; ");
        // }
        // double MaxPoint = Points.Max();
        // double MinPoint = Points.Min();

        // Console.WriteLine($"Diem lon nhat: {MaxPoint}");
        // Console.WriteLine($"Diem nho nhat: {MinPoint}");

        //thay doi size of array
        // Array.Resize(ref Points, 10);


        //viet ct tao mang voi cac gia tri dc user input

        // int i = 1;
        // int[] numberList = new int[1];
        // int number = 0;
        // while (true)
        // {
        //     Console.Write($"NumberList[{i - 1}] = ");
        //     numberList[i - 1] = Convert.ToInt32(Console.ReadLine());
        //     if (numberList[i - 1] == 0)
        //         break;
        //     Array.Resize(ref numberList, ++i);
        // }
        // do
        // {
        //     Console.Write($"NumberList[{i - 1}] = ");
        //     number = Convert.ToInt32(Console.ReadLine());
        //     if (number != 0)
        //     {
        //         numberList[i - 1] = number;
        //         Array.Resize(ref numberList, ++i);
        //     }
        //     else
        //     {
        //         Array.Resize(ref numberList, numberList.Length - 1);
        //     }
        //     Console.WriteLine(numberList.Length);
        // }
        // while (number != 0);

        // Console.WriteLine(string.Join(" - ", numberList));
        #endregion
        #region NestedArray

        // string[][] class_12_2 = new string[4][] 
        // {
        //     new string[5] {"L", "N", "T", "R", "H"},
        //     new string[3] {"L", "N", "T"},
        //     new string[2] {"L", "N"},
        //     new string[1] {"L"},
        // };

        // for (int team = 0; team < class_12_2.Length; team++)
        // {   
        //     // Console.Write($"team {team} - members: {string.Join(" - ", class_12_2[team])}");
        //     for (int men = 0; men < class_12_2[team].Length; men++)
        //     {   
        //         // Console.Write($"team{team} - count: {class_12_2[team].Length}");
        //         Console.Write($"{class_12_2[team][men]}\t");
        //     }
        //     Console.WriteLine();
        // }

        // string[][] family = new string[3][]
        // {
        //     new string[6] {"Co 2", "Co 3", "Chu", "Cau 2", "Cau 3", "Co ut"},
        //     new string[6] {"Co 2", "Co 3", "Co 4", "Co ut", "Cau 2", "Cau 3"},
        //     new string[5] {"Ba", "Me", "Toi", "Em trai", "Em gai"},
        // };

        // for (int nha = 0; nha < family.Length; nha++)
        // {
        //     for (int members = 0; members < family[nha].Length; members++)
        //     {   
        //         Console.Write($"{family[nha][members]}\t");
        //     }
        //     Console.WriteLine();
        // }
            
        // int[][] array = new int[3][] 
        // {
        //     new int[3] {2, 4, 5},
        //     new int[4] {3, 5, 6, 4},
        //     new int[5] {1, 2, 5, 3, 4}
        // };        
        // int sum = 0;
        
        // for (int element = 0; element < array.Length; element++)
        // {
        //     for (int number = 0; number < array[element].Length; number++)
        //     { 
        //         sum += array[element][number];
        //         Console.Write($"{array[element][number]}\t {sum}");
                
        //     }
        //     Console.WriteLine();
        // }

        // double[][] Point = new double[4][] 
        // {
        //     new double[4] {3.0 , 5.0 , 7.5 , 8.5},
        //     new double[4] {4.5 , 5.5 , 7.0 , 8.5},
        //     new double[4] {3.0 , 5.1 , 7.2 , 8.5},
        //     new double[4] {3.0 , 5.3 , 7.0 , 9.5},
        // };

        // for (int i = 0; i < Point.Length; i++)
        // {
        //     for (int number = 0; number < Point[i].Length; number++)
        //     {
        //         Console.Write($"{Point[i][number]}\t");
        //     }
        //     Console.WriteLine();
        // } 
        // double max = 0;
        // for (int i = 0; i < Point.Length; i++)
        // {
        //     for (int number = 0; number < Point[i].Length; number++)
        //     {
        //         if (Point[i][number] > max)
        //         {
        //             max = Point[i][number];
                    
        //         }
        //     }
        // }
        // Console.WriteLine($"max: {max}");

        #endregion
        #region Mang 2 chieu
        
        // double[,] point = new double[row, col];
        // double[,] point = new double[3, 5]
        // {
        //     {2, 3, 4, 5, 6},
        //     {2, 3, 4, 5, 6},
        //     {2, 3, 4, 5, 6}
        // };
        // //  hien so luong row vs col
        // // Console.WriteLine($"X = {point.GetLength(0)}");
        // // Console.WriteLine($"Y = {point.GetLength(1)}");

        // for (int row = 0; row < point.GetLength(0); row++)
        // {
        //     for (int col = 0; col < point.GetLength(1); col++)
        //     {
        //         Console.Write($"{point[row, col]}\t");
        //     }
        //     Console.WriteLine();
        // }
        
        //Tao 1 matrix 5x7 voi cac gia tri dc random [10, 90]
        // int[,] matrix = new int[5, 7];
        // Random random = new Random();

        // for (int row = 0; row < matrix.GetLength(0); row++)
        // {
        //     for (int col = 0; col < matrix.GetLength(1); col++)
        //     {
        //         matrix[row, col] = random.Next(10, 90);
        //         Console.Write($"{matrix[row, col]} ");
        //     }
        //     Console.WriteLine();
        // }

        // int[,] matrix = new int[7, 7];
        // Random random = new Random();

        // for (int row = 0; row < matrix.GetLength(0); row++)
        // {
        //     for (int col = 0; col < matrix.GetLength(1); col++)
        //     {
        //         matrix[row, col] = random.Next(100, 900);
                
        //         if (matrix[row, col] > 500)
        //         {   
        //             Console.Write($"{matrix[row, col]}\t");
        //             Console.ForegroundColor = ConsoleColor.Green;
        //             Console.ResetColor();
        //         } 
        //         if (matrix[row, col] < 300) 
        //         {   
        //             Console.Write($"{matrix[row, col]}\t");
        //             Console.ForegroundColor = ConsoleColor.Red;
        //             Console.ResetColor();
        //         }
        //         else 
        //         {
        //             Console.Write($"{matrix[row, col]}\t");
        //         }
        //     }
        //     Console.WriteLine();
        // }


        #endregion


    }

}