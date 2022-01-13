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

                Console.WriteLine("Решение уравнения x={0}", ur.Root());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}",ex.Message);
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
                    if (value == 0)
                    {
                        throw new Exception("Коэфициент к=0 не имеет смысла, уравнение не имеет решений");
                    }
                    else
                    {
                        _k = value;
                    }
                }
            }
            
            public double Koef_b
            {
                get { return _b; }
                set { _b = value; }
            }


            public double Root()
            {
                try
                {
                    double result= -_b / _k;

                    if(result.CompareTo(double.NaN)==0) //если вызвать Root сразу после создания класса, поля проинициализированы 0, 0/0 не вызывает исключения
                    {
                        throw new Exception("Неопределенный результат (деление 0 на 0)");
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw  ex;
                }
            }
        }
    }
}
