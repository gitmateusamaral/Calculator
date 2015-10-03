using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculator
    {
        public double Soma(double a, double b)
        {
            return (a + b);
        }

        public double Subt(double a, double b)
        {
            return (a - b);
        }

        public double Mult(double a, double b)
        {
            return (a * b);
        }

        public double Div(double a, double b)
        {
            return (a / b);
        }

        public double Pot(double a, int b)
        {

            double c = a;

            if (b == 0)
            {
                a = 1;
                return (a);
            }

            else
            {
                while (b > 1)
                {
                    a *= c;
                    b--;
                }
                return (a);


            }

        }
        

        public double Resto(double a, double b)
        {
            return (a % b);
        }

        public double Porcentagem(double a, double b)
        {
            double c = ((100 * b) / a);

            return (c);
        }

        public double Raiz(double a)
        {
            return (Math.Sqrt(a));
        }

        public double seno(double a)
        {
            return (Math.Sin(Math.PI*a/180));
        }

        public double cos(double a)
        {
            return (Math.Cos(Math.PI*a/180));
        }

        public double tan(double a)
        {
            return (Math.Tan(Math.PI*a/180));
        }

        public int fib_it(int a)
        {
            int num1 = 0;
            int num2 = 1;
            for(int i = 1; i <= a - 2; i++)
            {
                if (i % 2 == 1)
                    num1 += num2;
                else
                    num2 += num1;
            }
            if (a == 1)
                return num1;
            else
            {
                if (num1 > num2)
                    return num1;
                else
                    return num2;
            }
        }

        public int fib_rec(int a,int num1,int num2, int count)
        {
            if (a == 1)
                    return 0;
            else if (a == 2)
                    return 1;
            else if (count == a - 2)
            {  
                return num2;
            }
            else
            {
                count++;
                return fib_rec(a, num2, num1 + num2, count);
            }
                
        }
    }
}
