using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM313_Group5_FinalProject.Util
{
    public partial class InformationForm : Form
    {
        public InformationForm(string info, string header)
        {
            InitializeComponent();
            this.label1.Text = info;
            this.Text = header;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Right - this.Width), (Screen.PrimaryScreen.WorkingArea.Bottom - this.Height - 10));
            this.timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity == 0)
            {
                this.Dispose();
            }
            else
            {
                this.Opacity -= 0.02;
            }
        }
    }
}
