using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        const string _password = "Van";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterpassword:
            string password = Form2.Show("Пароль", "Введите пароль");
            if(password == "")
            {
                this.Close();
            }

            if(password != _password && password != "")
            {
                MessageBox.Show("Неверный пароль\nПопробуйте еще раз", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto enterpassword;
            }
        }

        private void lbllCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }
    }
}
