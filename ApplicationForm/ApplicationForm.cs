using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForm
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "")
            {
                MessageBox.Show("Name Can't Be Empty","Error!");
            }

            else if (UserNametextBox.Text == "")
            {
                MessageBox.Show("User Name Can't Be Empty", "Error!");
            }

            else if (PasstextBox.Text == "")
            {
                MessageBox.Show("Password Can't Be Empty", "Error!");
            }

            else if (ConfirmPasstextBox.Text == "")
            {
                MessageBox.Show("Confirm Password Can't Be Empty", "Error!");
            }

            else if (EmailtextBox.Text == "")
            {
                MessageBox.Show("Email Can't Be Empty", "Error!");
            }

            else if (MaleradioButton.Checked == false && FemaleradioButton.Checked == false)
            {
                MessageBox.Show("Gender Must Be Selected", "Error!");
            }

            else if (BloodGroupcomboBox.Text == "")
            {
                MessageBox.Show("Blood Group Must Be Selected", "Error!");
            }

            else if (DateofBirth.Text == "")
            {
                MessageBox.Show("Date of Birth Must Be Selected", "Error!");
            }

            else if (PasstextBox.Text != ConfirmPasstextBox.Text) 
            {
                MessageBox.Show("Confirm Password Doesn't Match!", "Error!");
            }

            else
            {
                /*Print print = new Print(this);
                this.Hide();
                print.Show();*/

                string gender = "";
                if (MaleradioButton.Checked)
                    gender = "Male";
                else if (FemaleradioButton.Checked)
                    gender = "Female";

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Insert into Users(Name,Username,Password,Email,DateofBirth,Gender,BloodGroup) values('"+NametextBox.Text+"','"+UserNametextBox.Text+"','"+PasstextBox.Text+"','"+EmailtextBox.Text+"','"+DateofBirth.Text+"','"+gender+"','"+BloodGroupcomboBox.Text+"')";

                SqlCommand command = new SqlCommand(sql, connection);
                int flag = command.ExecuteNonQuery();

                if (flag == 0)
                    MessageBox.Show("User Not Added!");

                else if (flag == 1)
                {
                    MessageBox.Show("User Added");
                    connection.Close();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }

            }

        }

        private void TermscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TermscheckBox.Checked)
                Submitbutton.Enabled = true;

            else
                Submitbutton.Enabled = false;
        }
    }
}
