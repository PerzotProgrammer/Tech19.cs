using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerazApkaForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void B1_OnClick(object sender, EventArgs e)
        {
            TextboxChecker tbChecker = new TextboxChecker();
            tbChecker.Show();
        }

        private void B2_OnClick(object sender, EventArgs e)
        {
            CurrentDate cd = new CurrentDate();
            cd.Show();
        }

        private void B4_OnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}