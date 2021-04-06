using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student Sform = new Student();
            Sform.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stud_Details sdetail = new Stud_Details();
            sdetail.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teacher tech = new Teacher();
            tech.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher_details t_details = new Teacher_details();
            t_details.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fees fee = new fees();
            fee.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dept department = new dept();
            department.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            record rec = new record();
            rec.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            displaycs detail = new displaycs();
            detail.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            logout out1 = new logout();
            out1.Show();
            this.Hide();
        }
    }
}
