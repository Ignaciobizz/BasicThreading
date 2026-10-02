using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        private Thread threadA;
        private Thread threadB;

        public FrmBasicThread()
        {
            InitializeComponent();

            // Manually connect the Run button
            btnRun.Click += BtnRun_Click;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";

            threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblMessage.Text = "-End Of Thread-";
        }
    }
}