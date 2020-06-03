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
        int time = 0;
        int redInterval = 10;
        int yellowInterval = 3;
        int greenInterval = 6;
        int totalTime = 0;
        public TraficLights()
        {
            InitializeComponent();
            InitilizeProgram();
            InitiulizeTimerSwitch();
            ClaculateStuffIdkDontAskMeWhatItDoesIDontKnowAndIDontWantToKnowWaitIDoKnowWhatItDoesIsntThisMethodsNameReallyLong();
        }
        private void InitilizeProgram()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;

            RedNumeric.Value = redInterval;
            YellowNumeric.Value = yellowInterval;
            GreenNumeric.Value = greenInterval;
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
            time++; 
            if (time >= totalTime)
            {
                time = 0;
            }
            if (time < redInterval)
            {
                GreenLight.BackColor = Color.Gray;
                RedLight.BackColor = Color.Red;
            }
            if (time == redInterval)
            {
                RedLight.BackColor = Color.Gray;
                YellowLight.BackColor = Color.Yellow;
            }
            if (time - redInterval == yellowInterval)
            {
                YellowLight.BackColor = Color.Gray;
                GreenLight.BackColor = Color.Green;
            }
        }
        private void Buttons_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag == "R")
            {
                redInterval = Decimal.ToInt32(RedNumeric.Value);
            }
            else if (button.Tag == "Y")
            {
                yellowInterval = Decimal.ToInt32(YellowNumeric.Value);
            }
            else
            {
                greenInterval = Decimal.ToInt32(GreenNumeric.Value);
            }
            ClaculateStuffIdkDontAskMeWhatItDoesIDontKnowAndIDontWantToKnowWaitIDoKnowWhatItDoesIsntThisMethodsNameReallyLong();
        }
        private void ClaculateStuffIdkDontAskMeWhatItDoesIDontKnowAndIDontWantToKnowWaitIDoKnowWhatItDoesIsntThisMethodsNameReallyLong()
        {
            totalTime = redInterval + yellowInterval + greenInterval;
        }
    }
}
