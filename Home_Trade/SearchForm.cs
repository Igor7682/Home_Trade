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
  
    public partial class SearchForm : Form
    {
        int UserID;
        bool admin;
        DataBase database = new DataBase();
        ToolStripMenuItem tsItem1 = new ToolStripMenuItem();
        ToolStripMenuItem tsItem3 = new ToolStripMenuItem();



        public SearchForm(int ID, bool isAdmin)
        {
            UserID = ID;
            admin = isAdmin;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
        }



        private void AddContextMenu()
        {
         
            tsItem1.Text = "Удалить";
            tsItem3.Text = "Предложить обмен";
            tsItem1.Click += new EventHandler(tsItem1_Click);
            ContextMenuStrip strip1 = new ContextMenuStrip();
          
            tsItem3.Click += new EventHandler(tsItem3_Click);

            if (admin == false)
            {
                tsItem1.Visible = false;
            }


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ContextMenuStrip = strip1;
                column.ContextMenuStrip.Items.Add(tsItem1);
                column.ContextMenuStrip.Items.Add(tsItem3);
            }
        }


       


        private void tsItem1_Click(object sender, EventArgs args)
        {
            int ind = dataGridView1.CurrentCell.RowIndex;
            int apId;

           

            dataGridView1.Rows[ind].Visible = false;
            apId = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
            database.apartDelete(apId);

            
        }

        private void tsItem3_Click(object sender, EventArgs args)
        {

            int ind = dataGridView1.CurrentCell.RowIndex;
            int apId = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
            int apUserId = database.getIdbyAp(apId);

            if (apUserId != UserID)
            {
                if (database.tradeOfferCheck(apId) != 3)
                {
                    dataGridView1.Rows[ind].Visible = false;
                    TradeOfferForm trForm = new TradeOfferForm(UserID, apId);
                    trForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("На это объявление уже ответили", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Нельзя ответить на свое объявление", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя пользователя");
            dataGridView1.Columns.Add("dist", "Район");
            dataGridView1.Columns.Add("sqr", "Площадь");
            dataGridView1.Columns.Add("layout", "Планировка");
            dataGridView1.Columns.Add("trade_state", "Состояние обмена");
            dataGridView1.Columns.Add("tarde_offer", "id предложения об обмене");
            AddContextMenu();    
        }


        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            string tradeState = "";
            
            
            switch (record.GetInt32(5))
            {
                case 0:
                    tradeState = "Открыто для обмена";
                    break;
                case 1:
                    tradeState = "Обмен произседен";
                    break;
                case 2:
                    tradeState = "Обмен отменен";
                    break;
                case 3:
                    tradeState = "Предложен обмен";
                    break;
                default:
                    tradeState = "Ошибка";
                    break;
            }
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4),tradeState ,record.GetInt32(6), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgv)
        {
            database.OpenConnection();
            dgv.Rows.Clear();

            string searchedDis;
            int MinSqr;
            int MaxSqr;
            string queryString; 
            int Search = textBoxCheck();
            
            int sqr;
            string layout;
            int Apartid;
            

            queryString = $"select id,owner_login, district,sqr,layout,trade_state,trade_offer_id from apartament";


            if (Search >= 100)
            {
                queryString += " where";
                if (Search >= 10000)  //  поле id
                {
                    Apartid = Convert.ToInt32(textBoxId.Text);
                    queryString += $" id ='{Apartid}'";
                    Search -= 10000;
                }

                if (Search >= 1000) //поле район
                {
                    layout = textBoxLayout.Text;
                    queryString += $" layout ='{layout}'";
                    Search -= 1000;
                }

                if (Search >= 100) //поле планировка
                {
                    searchedDis = textBoxDist.Text;
                    queryString += $" district ='{searchedDis}'";
                    Search -= 100;
                }
            }
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            SqlDataReader reader = command.ExecuteReader();
            
            

            switch (Search)
            {
                case 10:
                    dgv.Rows.Clear();
                    while (reader.Read())  //только минимальна площадь
                    {
                        
                        sqr = reader.GetInt32(3);
                        MinSqr = Convert.ToInt32(textBoxMinSqr.Text);
                        if (sqr >= MinSqr)
                        {
                            ReadSingleRow(dgv, reader);
                        }
                    }
                    break;
                case 11:
                    dgv.Rows.Clear();
                    while (reader.Read()) //миниимальная и максимальная 
                    {
                        sqr = reader.GetInt32(3);
                        MinSqr = Convert.ToInt32(textBoxMinSqr.Text);
                        MaxSqr = Convert.ToInt32(textBoxMaxSqr.Text);
                        if (sqr >= MinSqr && sqr <= MaxSqr)
                        {
                            ReadSingleRow(dgv, reader);
                        }
                    }
                    break;
                case 1:
                    dgv.Rows.Clear();
                    while (reader.Read()) //только максимальная
                    {
                        sqr = reader.GetInt32(3);
                        MaxSqr = Convert.ToInt32(textBoxMaxSqr.Text);
                        if (sqr <= MaxSqr)
                        {
                            ReadSingleRow(dgv, reader);
                        }
                    }
                    break;
                default:
                    dgv.Rows.Clear(); //ни одно поле не заполнено, выводит все
                    while (reader.Read())
                    {         
                       ReadSingleRow(dgv, reader);
                    }
                    break;
            }
             
            reader.Close();
            database.CloseConnection();

        }



        int textBoxCheck()
        {
            int Check = 0;
            if(textBoxId.Text != "") // id
            {
                Check += 10000;
            }

            if(textBoxLayout.Text != "") // планировка
            {
                Check += 1000;
            }

            if(textBoxDist.Text != "")  // район
            {
                Check += 100;
            }
            if(textBoxMinSqr.Text != "")  //минимальная площадь
            {
                Check += 10;
            }
            if (textBoxMaxSqr.Text != "") // максимальна площадь
            {
                Check += 1;
            }
            return Check;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxMinSqr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='.')
            {
                return;
            }

            if(e.KeyChar == ',')
            {
                e.KeyChar = '.';
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }


            if (Char.IsDigit(e.KeyChar) == true|| e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                e.Handled = true;
            }



        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxDist.Clear();
            textBoxMinSqr.Clear();
            textBoxMaxSqr.Clear();
            textBoxLayout.Clear();
        }

        private void textBoxLayout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_Click(sender, e);
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
