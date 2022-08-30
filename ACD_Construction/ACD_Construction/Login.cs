using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACD_Construction
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //----------------------------------------------
        BusinessLogicLayer BLL=new BusinessLogicLayer();
        //----------------------------------------------
        private void Login_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }
        //----------------------------------------------
        private void btn_showHide_Click_1(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == default)
            {
                txt_password.PasswordChar = '*';
            }
            else
            {
                txt_password.PasswordChar = default;
            }
        }
        //----------------------------------------------
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (!(rbtn_document.Checked || rbtn_register.Checked || rbtn_letter.Checked)) return;
            else
            {
                int answer = BLL.Login(txt_userName.Text, txt_password.Text);
                if (answer == 1)
                {
                    DocumentOperations doc = new DocumentOperations();
                    this.Hide();
                    doc.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
            }
        }
    }
}
