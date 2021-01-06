using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIM313_Group5_FinalProject.ChildComponents;

namespace BIM313_Group5_FinalProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            ViewAuthors viewAuthors = new ViewAuthors();
            ViewGenres viewGenres = new ViewGenres();        
            ViewPublishers viewPublishers = new ViewPublishers();
            ViewStocks viewStocks = new ViewStocks();
            Visitors visitors = new Visitors();
            Lends lends = new Lends();

            viewBooks.MdiParent = this;         //MdiChildren[0]
            viewAuthors.MdiParent = this;       //MdiChildren[1]
            viewGenres.MdiParent = this;        //MdiChildren[2]
            viewPublishers.MdiParent = this;    //MdiChildren[3]
            viewStocks.MdiParent = this;        //MdiChildren[4]
            visitors.MdiParent = this;          //MdiChildren[5]
            lends.MdiParent = this;             //MdiChildren[6]
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[0].Show();
        }

        private void viewAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[1].Show();
        }

        private void viewGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[2].Show();
        }

        private void viewPublishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[3].Show();
        }

        private void viewStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[4].Show();
        }

        private void visitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[5].Show();
        }    
        
        private void lendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form children in MdiChildren) children.Hide();
            MdiChildren[6].Show();
        }
    }
}
