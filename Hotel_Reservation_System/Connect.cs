using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Reservation_System
{
    /*
     * This class will connect between the application and the database
     * 
     * 
     * 
     */
    class CONNECT
    {



        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Ibrake4cats1!@;database=hotel;SSL Mode=none");
        //private MySqlConnection connection = new MySqlConnection("Server=localhost;User=root;port=3306;password=Ibrake4cats1!@;database=hotel;SSL Mode=none");
       
        public MySqlConnection getConnection()
        {

            //System.Windows.Forms.MessageBox.Show("connected");
            Console.WriteLine("Connection Successful");
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
