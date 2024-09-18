using System;
using System.Windows.Forms;

namespace TerazApkaForms
{
    public partial class TextboxChecker : Form
    {
        public TextboxChecker()
        {
            InitializeComponent();
        }

        private void Check_OnClick(object sender, EventArgs e)
        {
            if (tbCheck.Text != @"bye")
            {
                MessageBox.Show(@"Dawaj coś ciekawego", @"Dawaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else Close();
        }
    }
}