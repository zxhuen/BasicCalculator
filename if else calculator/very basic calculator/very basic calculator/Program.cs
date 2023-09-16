using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace very_basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstnumber;
            String ope;
            int secondnumber;
            int ans;
            int loop = 0;

            Console.WriteLine("Calculator - made by zxhuen");

            try
            {

                while (loop == 0)
                {

                    Console.WriteLine("Enter first number : ");
                    firstnumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("choose an operator : addition, subtraction, multiplication, division");
                    ope = Console.ReadLine();

                    Console.WriteLine("Enter second number : ");
                    secondnumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Result : ");

                    if (ope.Equals("addition"))
                    {
                        ans = firstnumber + secondnumber;
                        Console.WriteLine(ans);
                    }
                    else if (ope.Equals("subtraction"))
                    {
                        ans = firstnumber - secondnumber;
                        Console.WriteLine(ans);
                    }
                    else if (ope.Equals("multiplication"))
                    {
                        ans = firstnumber * secondnumber;
                        Console.WriteLine(ans);
                    }
                    else if (ope.Equals("division"))
                    {
                        ans = firstnumber / secondnumber;
                        Console.WriteLine(ans);
                    }

                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
