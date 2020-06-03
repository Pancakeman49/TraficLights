using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafic_lights
{
    public partial class TraficLights : Form
    {
        private Timer timerSwitch;
        public TraficLights()
        {
            InitializeComponent();
            InitilizeProgram();
            InitiulizeTimerSwitch();
        }
        private void InitilizeProgram()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
        private void InitiulizeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }
        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if (RedLight.BackColor == Color.Gray)
            {
                RedLight.BackColor = Color.Red;
            }
            else
            {
                RedLight.BackColor = Color.Gray;
            }
        }
    }
}
