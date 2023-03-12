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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainForm : Form
    {

       DataBase database = new DataBase();

       int UserID;
       bool admin;
       
        public MainForm(int ID,bool isAdmin)
        {
            admin = isAdmin;
            UserID = ID;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void button_makeAdv_Click(object sender, EventArgs e)
        {
            MakeAdv_Form Advform = new MakeAdv_Form(UserID);
            Advform.ShowDialog();
        }

        private void button_ShowUserAdv_Click(object sender, EventArgs e)
        {
            AdvShow advS = new AdvShow(UserID);
            this.Hide();
            advS.ShowDialog();
            this.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SearchForm SRform = new SearchForm(UserID,admin);
            this.Hide();
            SRform.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login_form newLogin = new Login_form();
            this.Hide();
            newLogin.ShowDialog();
        }
    }
}
