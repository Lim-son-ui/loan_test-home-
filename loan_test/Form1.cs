using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loan_test
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click1(object sender, EventArgs e)
        {
            double loanamount = double.Parse(txt1.Text);
            
            //MessageBox.Show("貸款數" + loanamount);
            double year = double.Parse(txt2.Text);
            
            year *= 12;
            //MessageBox.Show("年" + year);
            double rate = double.Parse(txt3.Text);
            
            rate = rate/12;
            rate = rate/100;
            //MessageBox.Show("利率" + rate);
            double firstincome = double.Parse(txt4.Text);

            double a = Math.Pow(1 + rate, year);
            //MessageBox.Show("次方數" + a);
            double month = a*rate/(a-1);
            int pay = Convert.ToInt32((loanamount-firstincome) * month);        //每月平攤
            //double secincome = Math.Pow(firstincome * (1 + rate), year);
            double sum = pay * year;                                            //總付款
            
            
            //MessageBox.Show("月付額是" + month);
            //MessageBox.Show("付款數" + pay);
            MessageBox.Show("付款數" + sum);

        }

        private void click2(object sender, EventArgs e)
        {

        }

        private void click3(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
