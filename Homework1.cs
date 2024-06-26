namespace Homework;


class Homework
{
    static void Main(String[] args)
    {

        // Bai 1 BMI
        // Console.Write("Input your weight: ");
        // var weight = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Input your Height: ");
        // var Height = Convert.ToDouble(Console.ReadLine());
        // var BMI = weight/(Height * Height);
        

        // if(weight > 0 && Height >0)
        // {   
        //     Console.WriteLine($"Your BMI: {BMI)}");
         
        //     if(BMI < 18.5 )
        //     {
        //         Console.Write("Gay");
        //     }
        //     if(BMI >= 18.5 && BMI <= 24.9)
        //     {
        //         Console.Write("Binh thuong");
        //     }
        //     if(BMI >= 25 && BMI <= 29.9)
        //     {
        //         Console.Write("Tang can");
        //     }
        //     if(BMI >= 30 && BMI <= 34.9)
        //     {
        //         Console.Write("Beo phi cap do 1");
        //     }
        //     if(BMI >= 35 && BMI <= 39.9)
        //     {
        //         Console.Write("Beo phi cap do 2");
        //     }
        //     if(BMI >= 40)
        //     {
        //         Console.Write("Beo phi cap do 3");
        //     }
        // }else if(weight <= 0 || Height <= 0)
        // {
        //     Console.Write("Nhap sai so lieu");
        // }


        // Bai 2 giai phuong trinh bac 2
        Console.Write("Input a: ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input b: ");
        var b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input c: ");
        var c = Convert.ToDouble(Console.ReadLine());
        var delta = b * b - 4 * a * c;

        if(a != 0)
        {
            Console.WriteLine($"delta = {delta}");
            if(delta == 0)  // 2,4,2
            {
                var x1 = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x1}");
            } 
            if(delta > 0)  //1,3,2
            {
                var x1 = -b + Math.Sqrt(delta) / (2 * a);
                var x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem la: x1 = {x1}, x2 = {x2}");
            } 
            if(delta < 0)  //5,1,2,
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            
        }
    }
}