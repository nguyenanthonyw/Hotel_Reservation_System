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

namespace Hotel_Reservation_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Connect conn = new Connect();
            DataTable table = new DataTable();
            DataSet dataSet = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM 'users' WHERE 'username'=@usn AND 'passwords'=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtBoxLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(dataSet);



            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");

            }
            else
            {
                MessageBox.Show("No");

            }


        }
    }
}
