using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory_system
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Tests dd = new Tests();
            dd.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Results ddd = new Results();
            ddd.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LaboratrianProfile dddd = new LaboratrianProfile();
            dddd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == ""|| comboBox3.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox4.Text == "" || comboBox7.Text == "" || dateTimePicker1.Text == "")
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
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox4.Text == "" || comboBox7.Text == "" || dateTimePicker1.Text == "")
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
    }
}
