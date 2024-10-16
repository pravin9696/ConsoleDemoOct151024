using System;

namespace ConsoleDemoOct151024
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment no 17
            //float x1, x2;
            //int b, a, c;
            //Console.WriteLine("Enter b ,a and c");
            //b = int.Parse(Console.ReadLine());
            //a = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());

            //x1 = (float)((-b) + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            //x2 = (float)((-b) - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            //Console.WriteLine("x1=" + x1);
            //Console.WriteLine("x2=" + x2);
            #endregion
            #region else if ladder demo
            /* int x = 1000;
             int y = 200;
             int z = 30;
             if (x<y)
             {
                 Console.WriteLine("statement 1");
             }
             else if(x<z)
             {
                 Console.WriteLine("statement 2");
             }
             else if(y<z)
             {
                 Console.WriteLine("statement 3");
             }
             else
             {
                 Console.WriteLine("else statement");
             }
             Console.WriteLine("this is new statement");
             */
            #endregion

            #region greatest among 3 numbers
            /*
            int n1, n2, n3;
            Console.WriteLine("Enter 3 numbers");
            n1=int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            if (n1>n2)//false
            {
                if (n1>n3)
                {
                    Console.WriteLine($"{n1} is greater");
                }
                else
                {
                    Console.WriteLine($"{n3} is greater");
                }

            }
            else
            {//n2 or n3
                if (n2>n3)//false
                {
                    Console.WriteLine($"{n2} is greater");
                }
                else
                {
                    Console.WriteLine($"{n3} is greater");
                }
            }
            */
            #endregion

            //int x = -3;
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2: Console.WriteLine("two"); break;
            //    case 3: Console.WriteLine("Three");
            //        break;

            //    default:
            //        Console.WriteLine("default .....");
            //        break;
            //}
            int a = 100;
            int b = 2000;
            int c = 400;
           
            switch (a > b)
            {
                case true:
                    switch (a>c)
                    {
                        case true:
                            Console.WriteLine("a is greater");
                            break;
                        case false:
                            Console.WriteLine("c is greater");
                            break;
                    }
                    break;
                case false:
                    switch (b > c)
                    {
                        case true:
                            Console.WriteLine("b is greater");
                            break;
                        case false:
                            Console.WriteLine("c is greater");
                            break;
                    }


                    break;

            }


            Console.ReadKey();
        }
    }
}
