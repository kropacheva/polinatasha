using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Form message = new Form();
            MessageBox.Show("Ваш логин:" + tbLogin.Text + "\nВаш пароль:" + tbPassword.Text);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void KeysComb(KeyEventArgs e, String tb)
        {
            if(e.Alt && e.KeyCode == Keys.J)
            {
                MessageBox.Show(tb);
            }
        }
        private void tbLogin_KeyDown_1(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbLogin.Text);
        }
        private void tbPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbPassword.Text);
        }
    }
}
