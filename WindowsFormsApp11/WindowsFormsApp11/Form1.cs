using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = "server=localhost;user=root;database=mydb;port=3306;password=SupermiNer@890";
                MySqlConnection conn = new MySqlConnection(connStr);
                label1.Text = "connection is succesful";
                label1.ForeColor = Color.Green;
            }
            catch(Exception p)
            {
                label1.Text = p.ToString();
                label1.ForeColor = Color.Red;

            }

        }
    }
}
