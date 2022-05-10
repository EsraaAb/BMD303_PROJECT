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
namespace laboratory_system
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="" ||textBox3.Text ==""|| comboBox1.Text ==""|| comboBox2.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    MessageBox.Show("Information have been saved successfully"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }       
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    MessageBox.Show("Information have been updated successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Donor ob = new Donor();
            ob.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tests kkk = new Tests();
            kkk.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Results rrr = new Results();
            rrr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LaboratrianProfile lll = new LaboratrianProfile();
            lll.Show();
            this.Hide();
        }
    }
}
