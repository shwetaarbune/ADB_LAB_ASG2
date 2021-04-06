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

namespace University_Management
{
    public partial class Student : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Shweta@456");
        MySqlCommand command;
        public Student()
        {
            InitializeComponent();
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if(connection.State==ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if(command.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Query executed");
                }
                else
                {
                    MessageBox.Show("Query Not executed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

          MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery= "INSERT INTO test.user(ID,UserName,First_name,Password,Address) VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','"+ textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            executeQuery(insertQuery);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
