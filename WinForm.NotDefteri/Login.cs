using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.NotDefteri
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsername.Text) && !string.IsNullOrEmpty(MskSifre.Text))
            {
                if (DataStore.AppUser.Username == TxtUsername.Text && DataStore.AppUser.Password == MskSifre.Text)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Application.Exit();
        }
    }
}
