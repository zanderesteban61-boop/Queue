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
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            if (CashierClass.CashierQueue.Count > 0)
            {
                string next = CashierClass.CashierQueue.Peek();
                LblNowServing.Text = "Now Serving: " + next;
            }

            CashierClass.OnQueueChanged += () =>
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                    string next = CashierClass.CashierQueue.Peek();
                    UpdateNowServing(next);
                }
            };
        }

        private static CustomerView instance;
        public static CustomerView Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new CustomerView();
                return instance;
            }
        }

        public void UpdateNowServing(string number)
        {
            if (LblNowServing.InvokeRequired)
            {
                LblNowServing.Invoke(new MethodInvoker(() =>
                    LblNowServing.Text = "" + number));
            }
            else
            {
                LblNowServing.Text = ": " + number;
            }
        }
    }
}

