using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace neuronal
{
    public partial class neuroncontrol : UserControl
    {
        public neuroncontrol()
        {
            InitializeComponent();
        }
        public List<neuroncontrol> listadelegaturi = new List<neuroncontrol>();
        public int ismd = 0;
        Graphics g;

        public void setG(ref Graphics gg)
        {
            g = gg;
        }
        private void neuroncontrol_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void neuroncontrol_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }

        private void neuroncontrol_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        public void drawLinks()
        {
            for (int i = 0; i < listadelegaturi.Count; i++)
            {
                try
                {
                    g.DrawLine(new Pen(Color.Black), listadelegaturi[i].Left, listadelegaturi[i].Top, listadelegaturi[i + 1].Left, listadelegaturi[i + 1].Top);
                }
                catch { }
            }
        }

        private void neuroncontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
