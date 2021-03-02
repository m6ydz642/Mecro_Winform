using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mecro_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 1;
            
            ylabel.Text = Cursor.Position.X.ToString();
            xlabel.Text = Cursor.Position.Y.ToString();
        }
    }
}
