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
    public partial class Reg_form : Form
    {
        DataBase database = new DataBase();

        public Reg_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (textCheck() == true)
            {
                string loginUser = textBox_login2.Text;
                string passUser = textBox_pass2.Text;

                
                if (database.userCheck(loginUser, passUser) == false)
                {
                    if (database.userAdd( loginUser, passUser) == true)
                    {
                        MessageBox.Show("Вы успешно зарегестрировались", "Регестраиця", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось зарегестриироваться", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с данным логином уже зарегестрирован", "Ошибка", MessageBoxButtons.OK);
                } 
               
            }
        }

        private bool textCheck()
        {
            if (textBox_login2.Text == "" || textBox_pass2.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
