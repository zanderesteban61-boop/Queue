using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm form2 = new CashierWindowQueueForm();
            form2.ShowDialog();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass.getNumberInQueue = CashierClass.CashierGeneratedNumber("P - ");
            lblQueue.Text = CashierClass.getNumberInQueue;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
        private void btnOpenQueueForm_Click_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm queueForm = new CashierWindowQueueForm();
            queueForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void btnOpenCashierQueue_Click(object sender, EventArgs e)
        {
            
            CashierWindowQueueForm form2 = new CashierWindowQueueForm();

            
            form2.Show();

        }
    }

}