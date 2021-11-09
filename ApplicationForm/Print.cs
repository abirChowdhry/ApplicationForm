using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForm
{
    public partial class Print : Form
    {
        public Print(ApplicationForm af)
        {
            InitializeComponent();

            label4.Text = af.NametextBox.Text;
            label9.Text = af.UserNametextBox.Text;
            label10.Text = af.PasstextBox.Text;
            label11.Text = af.EmailtextBox.Text;
            label12.Text = af.DateofBirth.Text;
            if (af.MaleradioButton.Checked == true) { label13.Text = "Male"; }
            else if (af.FemaleradioButton.Checked == true) { label13.Text = "Female"; }
            label14.Text = af.BloodGroupcomboBox.Text;
        }

        private void Print_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
