using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test_HotelReservationSystem
{
    public partial class FormSignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GOU\SQLEXPRESS;Initial Catalog=Test_HotelReservationSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == string.Empty ||
                textBoxUsername2.Text.Trim() == string.Empty ||
                textBoxPassword2.Text.Trim() == string.Empty ||
                textBoxAccountNo.Text.Trim() == string.Empty ||
                textBoxCVV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxPassword2.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxCVV.Text.Length != 3 || !textBoxCVV.Text.All(char.IsDigit))
            {
                MessageBox.Show("CVV must be a 3-digit number.", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxAccountNo.Text.Length < 8 || !textBoxAccountNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("Account Number must be at least 8 digits long and contain only numbers.", "Invalid Account Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM User_Table WHERE User_Name = @username", con);
                cmd.Parameters.AddWithValue("@username", textBoxUsername2.Text);

                int userCount = (int)cmd.ExecuteScalar();
                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd = new SqlCommand("INSERT INTO User_Table (Full_Name, User_Name, User_Password, Account_No, CVV) VALUES (@fullname, @username, @password, @accountNo, @cvv)", con);
                cmd.Parameters.AddWithValue("@fullname", textBoxName.Text);
                cmd.Parameters.AddWithValue("@username", textBoxUsername2.Text);
                cmd.Parameters.AddWithValue("@password", textBoxPassword2.Text);
                cmd.Parameters.AddWithValue("@accountNo", textBoxAccountNo.Text);
                cmd.Parameters.AddWithValue("@cvv", textBoxCVV.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void pictureBoxShow2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow2, "Show Password");
        }

        private void pictureBoxHide2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide2, "Hide Password");
        }
        private void pictureBoxShow2_Click_1(object sender, EventArgs e)
        {
            pictureBoxShow2.Hide();
            textBoxPassword2.UseSystemPasswordChar = false;
            pictureBoxHide2.Show();
        }
        private void pictureBoxHide2_Click_1(object sender, EventArgs e)
        {
            pictureBoxShow2.Show();
            textBoxPassword2.UseSystemPasswordChar = true;
            pictureBoxHide2.Hide();
        }
        private void linkLabelAlready_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }
    }
}