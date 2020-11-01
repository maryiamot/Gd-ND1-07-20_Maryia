using System;

namespace dz_02_11
{
    class MainClass
    {

    
            static void Main(string[] args)
            {
                Kalkulytor();
            }

            static public void Kalkulytor()
            {
                Yslovie();
                try
                {
                    double y;
                    double x = Convert.ToDouble(Console.ReadLine());
                    string s = Console.ReadLine();

                    switch (s)
                    {
                        case "!":
                            Factoriala(x);
                            goto case "End";
                        case "-":
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Minus(x, y));
                            goto case "End";
                        case "+":
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Sum(x, y));
                            goto case "End";
                        case "*":
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(Proizvedenie(x, y));
                            goto case "End";
                        case "/":
                            y = Convert.ToDouble(Console.ReadLine());
                            Delenie(x, y);
                            goto case "End";
                        case "^":
                            y = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine( Stepen(x, y));
                            goto case "End";
                        case "End":
                            Console.WriteLine("-----------------");
                            Kalkulytor();
                            break;
                        case "#":
                            break;
                        default:
                            Console.WriteLine("-----------------");
                            Kalkulytor();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Error! ne chislo");
                    Kalkulytor();
                }


            }

            static public void Yslovie()
            {
                Console.WriteLine("Uslovie ispol'zovaniya programmy!\n Summa '+', raznost' '-', proizvedenie '*', delenie '/', stepen' '^', faktorial '!' \n primer:\n 345\n +\n 678\n Vyhodom iz kal'kulyatora yavlyaetsya vvod na mesto arifmeticheskoj operacii znaka '#'");
            }

       
            static public void Factoriala(double x) //limit 170
            {
                double m = x - (int)x;
                if (m != 0 || x < 0)
                {
                    Console.WriteLine("nelza vuchislit factorial");
                }
                else
                {
                    double s = 1;
                    if (x == 0)
                        Console.WriteLine("1");
                    else
                    {
                        for (int i = 1; i <= x; i++)
                        {
                            s = s * i;
                        }
                        Console.WriteLine(s);
                    }

                }

            }

        static public double Stepen(double x, double y)
        {
            return Math.Pow(x, y);
        }

            static public void Delenie(double x, double y)
            {
                if (y == 0)
                    Console.WriteLine("poputka delenia na 0");
                else
                    Console.WriteLine(x / y);
            }

            static public double Sum(double x, double y)
            {
                return x + y;
            }

            static public double Minus(double x, double y)
            {
                return x - y;
            }

            static public double Proizvedenie(double x, double y)
            {
                return x * y;
            }

        }



    }
