using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Glimpse.Ado.Tab;
using System.Data.SqlClient;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Admin\\Desktop\\Database11.accdb");
            OleDbCommand command = new OleDbCommand("select * from Table1 ", connection);


            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable d = new DataTable();
            adapter.Fill(d);

            dataGridView1.DataSource = d;


        }
    }
}
