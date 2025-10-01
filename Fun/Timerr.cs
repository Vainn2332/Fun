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
    internal class Timerr
    {
        private Timer timer = new Timer();
        //private delegate void someEvent(object sender, EventArgs e);
        private EventHandler eventHandler;
        
        public Timerr(EventHandler eventHandler)
        {
            this.eventHandler = eventHandler;
        }
        public void StartTimer()
        {;
            timer.Interval = 500;//каждую  полусекунду
            timer.Tick += eventHandler;
            timer.Start();
        }
    }
}
