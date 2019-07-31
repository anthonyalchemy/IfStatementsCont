using System;

namespace IfStatementsCont
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(GetMax(20, 10));

            Console.WriteLine(GetMax2(20, 30, 40));


            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            //inside of if statement we can do comparisons 
            int result;

            if (num1 > num2)//condition inside brackets 
            {
                result = num1;

            }else
            {
                result = num2;
            }


            return result;



        }

        static int GetMax2(int num1, int num2, int num3)
        {
            //inside of if statement we can do comparisons 
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;

            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
      


            return result;



        }
    }
}
