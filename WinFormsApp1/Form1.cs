using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomersAndaluciaNuGet;
using CustomersAndaluciaNuGet;
using CustomersAndaluciaNuGet.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            NorthWindData data = new NorthWindData();
            CustomerList customers =
                await data.GetCustomerListAsync();
            foreach (Customer c in customers.Customers)
            {
                this.listBox1.Items.Add(c.Name);
            }
        }
    }
}
