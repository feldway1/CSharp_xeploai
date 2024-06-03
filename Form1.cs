using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_xeploai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblloai_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            Double toan, van, trungbinh;
            toan = Convert.ToDouble(txttoan.Text);
            van = Convert.ToDouble(txtvan.Text);
            trungbinh = (toan + van) / 2;
            txtTB.Text = trungbinh.ToString();
            if (trungbinh>=8) 
            {
                lblloai.Text = "Giỏi";
            }
            else if(6<trungbinh )
                {
                    lblloai.Text = "Khá";
                }
                else if (trungbinh >= 5)

                { 
                    lblloai.Text = "TB";
                }
                    else
                    {
                        lblloai.Text = "Yếu";
                    }

                    
                     
                        
                    
                
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblxeploai_Click(object sender, EventArgs e)
        {

        }

        private void lblTB_Click(object sender, EventArgs e)
        {

        }

        private void lblvan_Click(object sender, EventArgs e)
        {

        }

        private void lbltoan_Click(object sender, EventArgs e)
        {

        }

        private void lblten_Click(object sender, EventArgs e)
        {

        }
    }
}
