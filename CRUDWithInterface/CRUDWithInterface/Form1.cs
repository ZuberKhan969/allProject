using CRUDWithInterface.Iservices;
using CRUDWithInterface.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWithInterface
{
    public partial class Form1 : Form
    {
        customerService csi = new ICustomerService();
        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.FirstName = textBox1.Text;
            model.LastName = textBox2.Text;
            model.Address = textBox3.Text;
            model.city = textBox4.Text;
            csi.add(model);
            MessageBox.Show("User Create Successful");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            csi.deletebyId(Convert.ToInt16(textBox5.Text));
        }
    }
}
