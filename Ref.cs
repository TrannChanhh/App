namespace Method;
using System.Text;

class Ref
{

    static void Main(string[] arfgs)
    {
        // Console.InputEncoding = Encoding.Unicode;
        // Console.OutputEncoding = Encoding.Unicode;

        // while (true)
        // {
        //     Console.WriteLine("Menu");
        //     Console.WriteLine("Nhấn phím 1 để thực hiện phép cộng");
        //     Console.WriteLine("Nhấn phím 2 để thực hiện phép trừ");
        //     Console.WriteLine("Nhấn phím 3 để thực hiện phép nhân");
        //     Console.WriteLine("Nhấn phím 4 để thực hiện phép chia");
        //     Console.WriteLine("Nhấn phím 0 để thoát khỏi chương trình");
        //     Console.Write("Chọn phím: ");

        //     int choice;
        //     if (int.TryParse(Console.ReadLine(), out choice))
        //     {
        //         if (choice == 0)
        //         {
        //             Environment.Exit(0);
        //         }
        //         else if (choice >= 1 && choice <= 4)
        //         {
        //             Console.Write("Nhập số thứ nhất: ");
        //             double num1 = Convert.ToDouble(Console.ReadLine());

        //             Console.Write("Nhập số thứ hai: ");
        //             double num2 = Convert.ToDouble(Console.ReadLine());

        //             switch (choice)
        //             {
        //                 case 1:
        //                     Console.WriteLine("BẠN CHỌN PHÉP CỘNG");
        //                     Console.WriteLine($"Kết quả: {num1} + {num2} = {num1 + num2}");
        //                     break;
        //                 case 2:
        //                     Console.WriteLine("BẠN CHỌN PHÉP TRỪ");
        //                     Console.WriteLine($"Kết quả: {num1} - {num2} = {num1 - num2}");
        //                     break;
        //                 case 3:
        //                     Console.WriteLine("BẠN CHỌN PHÉP NHÂN");
        //                     Console.WriteLine($"Kết quả: {num1} * {num2} = {num1 * num2}");
        //                     break;
        //                 case 4:
        //                     if (num2 != 0)
        //                     {
        //                         Console.WriteLine("BẠN CHỌN PHÉP CHIA");
        //                         Console.WriteLine($"Kết quả: {num1} / {num2} = {num1 / num2}");
        //                     }
        //                     else
        //                     {
        //                         Console.WriteLine("Không thể chia cho 0. Vui lòng thử lại.");
        //                     }
        //                     break;
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
        //         }
        //     }
        //     // else
        //     // {
        //     //     Console.WriteLine("Vui lòng nhập một số hợp lệ.");
        //     // }



        //     // // int[] number = new int[4];
        //     // // Array.Resize(ref number, 5);

        //     // int number_1 = 10;
        //     // int number_2 = 20;
        //     // Console.WriteLine($"Number 1: {number_1}, Number 2: {number_2}");
        //     // Swap(number_1, number_2);

        //     // //Hoán đổi vị trí gán
        //     // /*
        //     //     B1: temp
        //     //     B2: temp = number_1 = 10
        //     //     B3: number_1 = number_2 = 20
        //     //     B4: number_2 = temp = 10
        //     // */
        //     //     Console.WriteLine($"nhap gia tri vao: ");
        //     //     double number_1 = Convert.ToDouble(Console.ReadLine());
        //     //     double number_2 = Convert.ToDouble(Console.ReadLine());
        //     //     Sum(ref number_1, ref number_2);
        //     //     Sub(ref number_1, ref number_2);
        //     //     Mul(ref number_1, ref number_2);
        //     //     Div(ref number_1, ref number_2);
        //     // }
        //     //         // static void Swap (int number_1, int number_2)
        //     //     // {
        //     //     //     int temp = number_1;
        //     //     //     number_1 = number_2;
        //     //     //     number_2 = temp;
        //     //     //     Console.Write($"Number 1: {number_1}, Number 2: {number_2}");
        //     //     // }

        //     // static double Sum(ref double number_1,ref double number_2)
        //     // {   
        //     //     double Sum = number_1 + number_2;
        //     //     Console.Write($"Tong: {Sum}");
        //     // }
        //     // static double Sub(ref double number_1,ref double number_2)
        //     // {
        //     //     double Sub = number_1 - number_2;
        //     //     Console.Write($"Hieu: {Sub}");
        //     // }
        //     // static double Mul(ref double number_1,ref double number_2)
        //     // {
        //     //     double Sub = number_1 * number_2;
        //     //     Console.Write($"Hieu: {Mul}");
        //     // }
        //     //  static double Div(ref double number_1,ref double number_2)
        //     // {
        //     //     double Sub = number_1 / number_2;
        //     //     Console.Write($"Hieu: {Div}");
        //     // }
        // }


        do
        {
            int choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Nhấn phím 1 để thực hiện phép cộng");
                Console.WriteLine("Nhấn phím 2 để thực hiện phép trừ");
                Console.WriteLine("Nhấn phím 3 để thực hiện phép nhân");
                Console.WriteLine("Nhấn phím 4 để thực hiện phép chia");
                Console.WriteLine("Nhân phím 0 để thoát khỏi chương trình");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 4);
            if (choice > 10 || choice < 0)
            {

            }
            double nb1 = 0;
            double nb2 = 0;
            if (choice == 1)
            {
                NhapSo(ref nb1, ref nb2);
                Console.WriteLine($"Phep Cong: {nb1} + {nb2} = {nb1 + nb2}");
            }
            else if (choice == 2)
            {
                NhapSo(ref nb1, ref nb2);
                Console.WriteLine($"Phep tru: {nb1} - {nb2} = {nb1 - nb2}");
            }
            else if (choice == 3)
            {
                NhapSo(ref nb1, ref nb2);
                Console.WriteLine($"Phep nhan: {nb1} x {nb2} = {nb1 * nb2}");
            }
            else if (choice == 4)
            {
                NhapSo(ref nb1, ref nb2);
                Console.WriteLine($"Phep chia: {nb1} / {nb2} = {nb1 / nb2}");
            }
            else if (choice == 0)
            {
                Environment.Exit(0);
            }
        } while (true);

    }
    static void NhapSo(ref double nb1, ref double nb2)
    {
        Console.WriteLine("Nhap so thu nhat: ");
        nb1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        nb2 = Convert.ToDouble(Console.ReadLine());
    }

}