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
    public partial class TradeOfferForm : Form
    {
        int ApartId;
        int UserId;

        DataBase database = new DataBase();

        public TradeOfferForm(int usid, int apid)
        {

            ApartId = apid;
            UserId = usid;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
            RefreshDataGrid(dataGridView1);
           
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
                    tradeState = "Обмен произведен";
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
            string login = database.getLogin(UserId);
            string queryString = $"select id,district,sqr,layout,trade_state,trade_offer_id from apartament where owner_id ='{UserId}'";
            database.OpenConnection();
            SqlCommand command = new SqlCommand(queryString, database.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader, login);
            }
            reader.Close();
            database.CloseConnection();
            
        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[ind].Cells[0].Value.ToString());
            database.tradeOfferChange(ApartId, id);
            this.Close();
        }
    }
}
