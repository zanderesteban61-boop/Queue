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

        
        public void DisplayCashierQueue(IEnumerable<string> CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (string obj in CashierList)
            {
                listCashierQueue.Items.Add(obj);
            }
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
               
                CashierClass.CashierQueue.Dequeue();
            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }
    }
    }
