using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*float sector, radius,  area;
           sector = float.Parse(Console.ReadLine());
            radius = float.Parse(Console.ReadLine());
           area = float.Parse(Console.ReadLine());

           (sector*0.5f)*(radius*radius*)
             Console.WriteLine(area);
        }

        float c, a, b, area;
       c = float.Parse(Console.ReadLine());
       a = float.Parse(Console.ReadLine());
      b = float.Parse(Console.ReadLine());

       area = ((0.5f) * c) * (a + b);
            Console.WriteLine("{0}", area);

            boolean p = true ;
        boolean q = false ;
         q == p&&(!p||!q);
         Console.WriteLine();
    }

}*/
            int pass;
            Console.Write("your password:");
            int.TryParse(Console.ReadLine(), out pass);
            Console.Write("user organization:");
            string T;
            T = Console.ReadLine();
            int a;
            int b;
            int c;
            int d;
            int g;
            int h;
            a = pass / 100000;
            b = (pass / 10000) % 10;
            c = (pass / 1000) % 10;
            d = (pass / 100) % 10;
            g = (pass / 10) % 10;
            h = pass % 10;
            if (T == "CIA")
            {
                if (h % 3 != 0)
                {
                    Console.WriteLine("error1");
                }
                if (g != 1 && g != 3 && g != 5)
                {
                    Console.WriteLine("error2");
                }
                if (c >= 6 && c != 8)
                {
                    Console.WriteLine("error3");
                }
                else
                {
                    Console.WriteLine("ture");
                }
               
            }
            if (T == "FBI") { 
                if (a<=4&&a>=7) {
                    Console.WriteLine("error1");
                }
                if (d % 2 != 0 && a != 6) 
                {
                    Console.WriteLine("error2");
                    }
                if (b % 2 == 0)
                {
                    Console.WriteLine("error3");
                }
                else {
                    Console.WriteLine("ture");
                }
            }
            if (T == "NSA")
            {
                if (a == 7) 
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                if (b == 7)
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                if (c == 7)
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                if (d == 7)
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                if (g == 7)
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                if (h == 7)
                {
                    if (h == 1 && h == 2 && h == 3 && h == 5 && h == 6)
                    {
                        Console.WriteLine("error1");
                    }
                    if (d != 3 && d != 9)
                    {
                        Console.WriteLine("error2");
                    }
                    else
                    {
                        Console.WriteLine("ture");
                    }
                }
                else
                {
                    Console.WriteLine("ture");
                }
            }
        }
    }
}
      
            
