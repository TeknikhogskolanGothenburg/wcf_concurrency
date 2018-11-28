using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        SingleService.SingleServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SingleService.SingleServiceClient();
        }

        private void evenBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = client.GetEvenNumbers(20);
        }

        private void evenBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lstEvenNumbers.DataSource = (int[])e.Result;
        }

        private void oddBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = client.GetOddNumbers(20);
        }

        private void oddBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lstOddNumbers.DataSource = (int[])e.Result;
        }

        private void btnGetEvenNumbers_Click(object sender, EventArgs e)
        {
            evenBackgroundWorker.RunWorkerAsync();
        }

        private void btnGetOddNumbers_Click(object sender, EventArgs e)
        {
            oddBackgroundWorker.RunWorkerAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstEvenNumbers.DataSource = null;
            lstOddNumbers.DataSource = null;
        }
    }
}
