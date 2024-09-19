using System;
using System.Windows.Forms;

namespace TerazApkaForms
{
    public partial class MathLesson : Form
    {
        public MathLesson()
        {
            InitializeComponent();
        }


        public void Submit_OnClick(object sender, EventArgs e)
        {
            int num1 = int.Parse(inp1.Text);
            int num2 = int.Parse(inp2.Text);

            int gcdOut = Gcd(num1, num2);
            int lcmOut = Lcm(num1, num2);

            label1.Text = $@"NWD: {gcdOut} NWW: {lcmOut}";
        }

        private int Gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            return a | b;
        }

        private int Lcm(int a, int b)
        {
            int num1;
            int num2;
            if (a > b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;
                num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0) return mult;
            }

            return num1 * num2;
        }
    }
}