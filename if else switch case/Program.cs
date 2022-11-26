using System;

namespace if_else_switch_case
{
    class Program
    {
        
        private static float result;

        static void Main(string[] args)

        {   //if else $$ ||

            Console.WriteLine("Bari galus mer bank");
            Console.WriteLine("Cankanum eq nerdnel avand");
            Console.WriteLine("Sa katarvel e if elsi mijocov");
            int deposit = int.Parse(Console.ReadLine());

            if (deposit >= 200000)
            {
                result = deposit * 1.25f;
            }

            else if (deposit >= 10000)
            {
                result = deposit * 1.2f;

            }

            else
            {
                result = deposit * 1.1f;
            }

            Console.WriteLine("Dzer tarekan ekamut@ kazmum e" + result + "$");
            Console.WriteLine("karox es gushakel zenqi anun@");

            //switch case

            int a = int.Parse(Console.ReadLine());
            

           
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Tank");
                        break;

                    case 2:
                        Console.WriteLine("Hmma");
                        break;
                    case 3:
                        Console.WriteLine("kalash");
                        break;
                    case 4:
                        Console.WriteLine("Iskander");
                        break;
                    case 5:
                        Console.WriteLine("Ragatka");
                        break;

                    default:
                        Console.WriteLine("Myus angam kstacvi");
                        break;

                 }
            }

        }
    }
}
