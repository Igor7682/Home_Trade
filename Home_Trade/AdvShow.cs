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


    public partial class AdvShow : Form
    {
        int UserID;
        DataBase database = new DataBase();

        ToolStripMenuItem tsItem2 = new ToolStripMenuItem();
    
        ToolStripMenuItem stateItem1 = new ToolStripMenuItem();
        ToolStripMenuItem stateItem2 = new ToolStripMenuItem();
        ToolStripMenuItem stateItem3 = new ToolStripMenuItem();

        public AdvShow(int ID)
        {
            UserID = ID;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
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

        private void AddContextMenu()
        {

            
            tsItem2.Text = "Выбрать состояние";
            ContextMenuStrip strip1 = new ContextMenuStrip();

            stateItem1.Text = "Открыто для обмена";
            stateItem2.Text = "Обмен произведен";
            stateItem3.Text = "Отказ от обмена";

            tsItem2.DropDownItems.AddRange(new ToolStripItem[] { stateItem1, stateItem2, stateItem3 });

           


            tsItem2.MouseEnter += new EventHandler(MouseEnterItem);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {


                column.ContextMenuStrip = strip1;
                column.ContextMenuStrip.Items.Add(tsItem2);
               
            }

            stateItem1.Click += new EventHandler(StateCheckZero);
            stateItem2.Click += new EventHandler(StateCheckOne);
            stateItem3.Click += new EventHandler(StateCheckTwo);


        }

        private void MouseEnterItem(object sender, EventArgs args)
        {
            int ind = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
            int tradeState = database.tradeStateCheck(id);

            switch (tradeState)
            {
                case 0:
                    stateItem1.Checked = true;
                    stateItem2.Checked = false;
                    stateItem3.Checked = false;
                    break;
                case 1:
                    stateItem1.Checked = false;
                    stateItem2.Checked = true;
                    stateItem3.Checked = false;
                    break;
                case 2:
                    stateItem1.Checked = false;
                    stateItem2.Checked = false;
                    stateItem3.Checked = true;
                    break;
                default:
                    stateItem1.Checked = false;
                    stateItem2.Checked = false;
                    stateItem3.Checked = false;
                    break;
            }
        }



        private void StateCheckZero(object sender, EventArgs args)
        {
            if (stateItem1.Checked == false)
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
                int state = 0;
                database.tradeStateChange(id, state);
                database.tradeOfferReset(id);
            }
        }
        private void StateCheckOne(object sender, EventArgs args)
        {
            if (stateItem2.Checked == false)
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
                int state = 1;
                database.tradeStateChange(id, state);
            }
        }
        private void StateCheckTwo(object sender, EventArgs args)
        {
            if (stateItem3.Checked == false)
            {
                int ind = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
                int state = 2;
                database.tradeStateChange(id, state);
            }
        }



        private void ReadSingleRow(DataGridView dgv, IDataRecord record, string login)
        {
            string tradeState = "";

            switch (record.GetInt32(4))
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
            }


            dgv.Rows.Add(record.GetInt32(0), login, record.GetString(1), record.GetInt32(2), record.GetString(3), tradeState, record.GetInt32(5), RowState.ModifiedNew);

        }


        private void RefreshDataGrid(DataGridView dgv)
        {

          
            dgv.Rows.Clear();

            string login = database.getLogin(UserID);

            string queryString = $"select id,district,sqr,layout,trade_state,trade_offer_id from apartament where owner_id ='{UserID}'";

            database.OpenConnection();
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader, login);
                }
                reader.Close();
               
            }
            else
            {
                MessageBox.Show("Вы не создали ни одного объявления", "Ошибка", MessageBoxButtons.OK);
            }
            database.CloseConnection();
        }

        private void button_ShowUserAdv_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

    }
}
