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
    public partial class LedView : UserControl
    {
        public LedView()
        {
            InitializeComponent();
            pictureBox1.Image = Resource.LedOff;
        }

        // Property für Zustand der LED
        private bool state;
        public bool State{
            get{ return state;}
            set{ state = value;}
        }

        public void updateLED(){
            if(state == true){
                pictureBox1.Image = Resource.LedOn;
            }
            else{
                pictureBox1.Image = Resource.LedOff;
            }
        }




    }
}
