using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace InsertData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=20-PC\SQLEXPRESS;Initial Catalog=Student_Portal;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection_string);

            string query="Insert into Login(Name,Class)Values('"+textBox1.Text+"','"+textBox2.Text+"')";


            con.Open();

            SqlCommand command = new SqlCommand(query,con);
            command.ExecuteNonQuery();
            MessageBox.Show("Record inserted!");
            con.Close();
        }
    }
}
