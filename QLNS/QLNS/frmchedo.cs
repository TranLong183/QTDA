using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmchedo : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        public frmchedo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void frmchedo_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt5.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt6.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt7.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            dt2.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            dt3.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            dt4.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            dt5.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt8.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt9.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString());
            
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dt1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //try
            //{

               
            //catch
            //{
            //    MessageBox.Show("Dữ liệu đầu vào không đúng");
            //}
        }
    }
}
