using System;
using System.Windows.Forms;

namespace TerazApkaForms
{
    public partial class CurrentDate : Form
    {
        public CurrentDate()
        {
            InitializeComponent();
            CurrentDate_Load();
        }

        private void CurrentDate_Load()
        {
            string dt = DateTime.Now.ToShortDateString();
            date.Text = dt;
        }
    }
}