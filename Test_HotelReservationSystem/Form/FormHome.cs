using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_HotelReservationSystem
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signupForm = new FormSignUp();
            signupForm.Show();
            this.Hide();
        }
    }
}