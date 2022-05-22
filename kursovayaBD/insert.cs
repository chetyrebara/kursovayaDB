using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovayaBD
{
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("server = localhost; port=3306;username=root;password=root;database=new_schema1");
        private void amogus(object sender, EventArgs e)
        {

            DataTable table = new DataTable();

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                MySqlCommand command;

                connection.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    command = new MySqlCommand("INSERT INTO `currency` (`Id`, `Name`, `Amount`) VALUES(@ID,@Nm,@Am)", connection);

                    command.Parameters.Add("@ID", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    command.Parameters.Add("@Nm", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    command.Parameters.Add("@Am", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    command.ExecuteNonQuery();
                }

                connection.Close();

        }
    }
}
