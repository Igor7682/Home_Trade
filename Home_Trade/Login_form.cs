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



namespace Home_Trade
{
    public partial class Login_form : Form
    {
        DataBase database = new DataBase();

        bool admin;

        public Login_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        // string loginUser = "admin";
        // string passUser = "admin";




        private void login_button_Click(object sender, EventArgs e)
        {
            if (textCheck() == true)
            {
                string loginUser = textBox_login.Text;
                string passUser = textBox_Pass.Text;
                int ID;

                
                if (database.userCheck(loginUser, passUser) == true)
                {
                    admin = database.adminCheck(loginUser, passUser);
                    ID = database.getID(loginUser);
                    database.CloseConnection();
                    MainForm Mainform = new MainForm(ID, admin);
                    this.Hide();
                    Mainform.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Reg_form regform = new Reg_form();
            regform.Show();
        }


        private bool textCheck()
        {
            if (textBox_login.Text == "" || textBox_Pass.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void textBox_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login_button_Click(sender,e);
            }
        }
    }
}
