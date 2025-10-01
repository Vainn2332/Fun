using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun
{
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
            
        }

        private void StartingForm_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
