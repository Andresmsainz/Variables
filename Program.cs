using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 2;
            x = x + 5;
            Console.WriteLine("x = " + x);

            double dbl_num = 0.0d;
            float flt_num = 0.0f;
            decimal dcm_num = 0.0m;

            dbl_num = 9.8d;
            flt_num = 5.5f;
            dcm_num = 100.250m;


            Console.WriteLine("dbl_num = " + dbl_num);
            Console.WriteLine("flt_num = " + flt_num);
            Console.WriteLine("dcm_num = " + dcm_num);

            char letter_1 = 'A';
            Console.WriteLine("letter_1 = " + letter_1);

            string sFirstName = "Jon";
            string sLastName = "Snow";
            string sHouse = "Stark";
            Console.WriteLine("Whole Name = " + sFirstName + " " + sLastName + " of house " + sHouse);

            bool bIsWorking;
            bIsWorking = false;
            Console.WriteLine("bIsWorking = " + bIsWorking);

            int int_Sum = 0;
            int int_Num1, int_Num2;

            int_Num1 = 5;
            int_Num2 = 4;
            int_Sum = int_Num1 + int_Num2;

            Console.WriteLine("int_Num1 = " + int_Num1);
            Console.WriteLine("int_Num2 = " + int_Num2);
            Console.WriteLine("int_Sum = " + int_Sum);

        }
    }
}
