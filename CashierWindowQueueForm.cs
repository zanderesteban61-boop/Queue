using System;
using System.Collections;
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

    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()

        {
            InitializeComponent();
        }




        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());

            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string nowServingNumber = CashierClass.DequeueNumber();

            if (nowServingNumber != null)
            {
                CustomerView.Instance.Show();
                CustomerView.Instance.BringToFront();

              
                CustomerView.Instance.UpdateNowServing(nowServingNumber);
            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
