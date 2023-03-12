using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Trade
{
    public partial class MakeAdv_Form : Form
    {
        DataBase database = new DataBase();
        int  UserID;

        public MakeAdv_Form(int ID)
        {
            UserID = ID;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_CreateApart_Click(object sender, EventArgs e)
        {

            if(textCheck() == true)
            {
                
                string district = textBox_District.Text;
                string sqr = textBox_sqr.Text;
                string layout = textBox_lay.Text;
                string login = database.getLogin(UserID);

                if(database.apartAdd(UserID,district, sqr,layout,login)==true)
                {
                    MessageBox.Show("Вы создали новое объявление", "Объявление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Не удалось создать объявление", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else 
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK);
            }
        }


        private bool textCheck()
        {
            if (textBox_District.Text == "" || textBox_sqr.Text == "" || textBox_lay.Text == "")
            {
                return false;
            }
            else
                return true;
        }

        private void textBox_sqr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                return;
            }

            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
                return;
            }


            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
