using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool IsValidUsernameOrPasswordCharacter(char c)
        {
            if (char.IsLetterOrDigit(c))
                return true;

            if (c == '_' || c == '.' || c == '-' || c == '@')
                return true;

            if (c == '\b')
                return true;
            
            return false;
        }
        private bool IsAllowedCharacter(char c)
        {
            return char.IsLetterOrDigit(c) || c == '_' || c == '.' || c == '-' || c == '@';
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!="" && txtPassword.Text != "") 
            {
                DataAccess.EmployeeRepository repo = new DataAccess.EmployeeRepository();
                bool success = repo.Login(txtUserName.Text, txtPassword.Text);
                if (success)
                {
                    var emp = repo.GetEmployeeByUserName(txtUserName.Text);
                    frmMain frm = new frmMain(emp);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("ورود امکانپذیر نمی باشد ، لطفا اطلاعات را به درستی وارد کنید.");
                }
            }
            else
            {
                MessageBox.Show("مقادیر نمی تواند خالی باشد.");
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex.IsMatch(e.KeyChar.ToString(),@"[a-zA-Z-0-9_.\-@]")&&e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show(".فقط حروف انگلیسی،اعداد و علایم(@ _ - .) مجازند", "هشدار", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox=sender as TextBox;
            int selectionStart=txtBox.SelectionStart;
            txtBox.Text = string.Concat(txtBox.Text.Where(IsAllowedCharacter));
            txtBox.SelectionStart = selectionStart;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z-0-9_.\-@]") && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show(".فقط حروف انگلیسی،اعداد و علایم(@ _ - .) مجازند", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            int selectionStart = txtBox.SelectionStart;
            txtBox.Text = string.Concat(txtBox.Text.Where(IsAllowedCharacter));
            txtBox.SelectionStart = selectionStart;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                MessageBox.Show("لطفا مستقیما متن را تایپ کنید");
            }
        }
    }
}
