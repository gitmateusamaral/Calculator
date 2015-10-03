using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Calculator Calculadora;
        public double a;
        public double b;
        public bool p = false;
        public int x;
        public string type = "nada";

        public Form1()
        {
            InitializeComponent();
            Calculadora = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Digitou(object sender, EventArgs e)
        {
            Button Digitou = sender as Button;
            Result.Text += Digitou.Text ;
        }

        private void Soma(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "soma";
            }
            else if (type.Equals("soma") && !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Soma(a, b)).ToString();
                p = false;
                type = "nada";
            }
         
        }

        private void Subt(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "subt";
            }

            else if (type.Equals("subt") && !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Subt(a, b)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Mult(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "Mult";
            }
            else if (type.Equals("Mult") && !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Mult(a, b)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Div(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "Div";
            }
            else if (type.Equals("Div")&& !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Div(a, b)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Pot(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "Pot";
            }
            else if (type.Equals("Pot") && !string.IsNullOrEmpty(Result.Text))
            {
                x = int.Parse(Result.Text);
                Result.Text = (Calculadora.Pot(a, x)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Raiz(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = (Calculadora.Raiz(a)).ToString();
            }

        }

        private void Porc(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "Porc";
            }
            else if (type.Equals("Porc") && !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Porcentagem(a, b)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Rest(object sender, EventArgs e)
        {
            if (!p && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = "";
                p = true;
                type = "Rest";
            }
            else if (type.Equals("Rest") && !string.IsNullOrEmpty(Result.Text))
            {
                b = double.Parse(Result.Text);
                Result.Text = (Calculadora.Resto(a, b)).ToString();
                p = false;
                type = "nada";
            }
        }

        private void Seno(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = (Calculadora.seno(a).ToString());
            }
        }

        private void Coseno(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = (Calculadora.cos(a).ToString());
            }
        }

        private void Tangente(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                Result.Text = (Calculadora.tan(a).ToString());
            }
        }

        private void Iterativa_Click(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text))
            {
                a = double.Parse(Result.Text);
                double r = 1;

                for (var i = 1; i <= a; i++)
                {
                    r *= i;
                }

                Result.Text = r.ToString();

            }
        }

        private void Recursiva_Click(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text))
            Result.Text = recursiva(double.Parse(Result.Text)).ToString();
        }

        public double recursiva(double n1)
        {
            if (n1 == 0)
                return 1;
            return recursiva(n1 - 1) * n1;
        }
        private void Clean(object sender, EventArgs e)
        {
            p = false;
            Result.Text = "";
            type = "nada";
        }

        private void Change(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void Equivale(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Result.Text))
            {
                switch (type)
                {
                    case "soma":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Soma(a, b)).ToString();
                        p = false;
                        type = "nada";

                        break;
                    case "Subt":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Subt(a, b)).ToString();
                        p = false;
                        type = "nada";

                        break;
                    case "Mult":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Mult(a, b)).ToString();
                        p = false;
                        type = "nada";

                        break;
                    case "Div":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Div(a, b)).ToString();
                        p = false;
                        type = "nada";
                        break;
                    case "Pot":
                        x = int.Parse(Result.Text);
                        Result.Text = (Calculadora.Pot(a, x)).ToString();
                        p = false;
                        type = "nada";
                        break;
                    case "Porc":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Porcentagem(a, b)).ToString();
                        p = false;
                        type = "nada";
                        break;
                    case "Rest":
                        b = double.Parse(Result.Text);
                        Result.Text = (Calculadora.Resto(a, b)).ToString();
                        p = false;
                        type = "nada";
                        break;
                }
            }
        }

        private void FibIt_Click(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text) && int.Parse(Result.Text) != 0)
                Result.Text = Calculadora.fib_it(int.Parse(Result.Text)).ToString();
            else
            {
                Result.Text = "";
            }
        }

        private void FibRec_Click(object sender, EventArgs e)
        {
            if (type.Equals("nada") && !string.IsNullOrEmpty(Result.Text) && int.Parse(Result.Text) != 0)
                Result.Text = Calculadora.fib_rec(int.Parse(Result.Text), 0, 1, 0).ToString();
            else
            {
                Result.Text = "";
            }
        }
    }
}
