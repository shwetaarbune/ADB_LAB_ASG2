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
    public partial class dept : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Shweta@456");
        MySqlCommand command;
        public dept()
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
            if (connection.State == ConnectionState.Open)
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
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executed");
                }
                else
                {
                    MessageBox.Show("Query Not executed");
                }
            }
            catch (Exception ex)
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
            string insertQuery = "INSERT INTO test.department(Student_id,Department_name,Dept_id) VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')";
            executeQuery(insertQuery);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
