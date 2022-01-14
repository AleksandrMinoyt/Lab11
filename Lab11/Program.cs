using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //0=kx+b ; kx=-b ; x=-b/k
            Lin ur = new Lin();

            Console.WriteLine("Решение уравнения вида 0=kx+b");
            try
            {
                Console.WriteLine("Введите коэффициент k");
                ur.Koef_k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите коэффициент b");
                ur.Koef_b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Решение уравнения {0}", ur.Root());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            Console.ReadKey();
        }


        public struct Lin
        {
            private double _k;
            private double _b;

            public double Koef_k
            {
                get { return _k; }
                set
                {
                    _k = value;

                }
            }

            public double Koef_b
            {
                get { return _b; }
                set { _b = value; }
            }


            public Lin(double k, double b)
            {
                _k = k;
                _b = b;
            }


            public string Root()
            {

                if (_b == 0 && _k == 0)
                {
                    return "Любое число";
                }
               
                if (_k == 0)
                {
                    return "Уравнение не имеет решения";
                }

                double result = -_b / _k;
                return string.Format("x={0}",result);

            }
        }
    }
}
