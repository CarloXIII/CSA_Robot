using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class SwitchView : UserControl
    {
        public SwitchView()
        {
            InitializeComponent();
            pictureBox2.Image = Resource.SwitchOff;
        }
       
        private bool state;
        public bool State
        {
            get { return state; }
            set { state = value; }
        }

        public void updateSwitch()
        {
            if (state == true)
            {
                pictureBox2.Image = Resource.SwitchOn;
            }
            else
            {
                pictureBox2.Image = Resource.SwitchOff;
            }
        }



    }
}
