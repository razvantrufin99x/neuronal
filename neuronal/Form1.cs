using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace neuronal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<neuroncontrol> neuronallist = new List<neuroncontrol>();

        public Graphics g;
        public Pen pen0 = new Pen(Color.Black, 1);
        public Brush brush0 = new SolidBrush(Color.Black);
        public Font font0 = new Font("Arial", 10);

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.DrawEllipse(pen0, 100, 100, 620, 210);

            neuronallist.Add(neuroncontrol1);
            neuronallist.Add(neuroncontrol2);
            neuronallist.Add(neuroncontrol3);
            neuronallist.Add(neuroncontrol4);
            neuronallist.Add(neuroncontrol5);
            neuronallist.Add(neuroncontrol6);
            neuronallist.Add(neuroncontrol7);
            neuronallist.Add(neuroncontrol8);
            neuronallist.Add(neuroncontrol9);
            neuronallist.Add(neuroncontrol10);

            neuroncontrol1.listadelegaturi.Add(neuroncontrol2);
            neuroncontrol1.listadelegaturi.Add(neuroncontrol3);
            neuroncontrol1.listadelegaturi.Add(neuroncontrol5);
            neuroncontrol1.listadelegaturi.Add(neuroncontrol8);
            neuroncontrol1.setG(ref g);

            neuroncontrol2.listadelegaturi.Add(neuroncontrol10);
            neuroncontrol2.listadelegaturi.Add(neuroncontrol8);
            neuroncontrol2.listadelegaturi.Add(neuroncontrol1);
            neuroncontrol2.listadelegaturi.Add(neuroncontrol7);
            neuroncontrol2.setG(ref g);
           

        }

        public void drawallneuronslinks()
        {
            g.Clear(BackColor);
            neuroncontrol1.drawLinks();
            neuroncontrol2.drawLinks();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            drawallneuronslinks();
        }
    }
}
