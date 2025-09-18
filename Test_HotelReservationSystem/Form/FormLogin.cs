using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_HotelReservationSystem
{
    public partial class FormLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Test_HotelReservationSystem;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }
        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp signupForm = new FormSignUp();
            signupForm.Show();
            this.Hide();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter your username and password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM User_Table WHERE User_Name=@username AND User_Password=@password", con);
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        FormHome formHome = new FormHome();
                        formHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }
    }
}