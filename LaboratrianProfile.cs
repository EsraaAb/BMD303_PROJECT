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
    public partial class LaboratrianProfile : Form
    {
        public LaboratrianProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == ""||textBox4.Text =="")
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
            if (textBox1.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox5.Text == "" || textBox4.Text == "")
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Donor obj = new Donor();
            obj.Show();
            this.Hide(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Tests k = new Tests();
            k.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Results rrrr = new Results();
            rrrr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LaboratrianProfile l = new LaboratrianProfile();
            l.Show();
            this.Hide();
        }
    }
}
