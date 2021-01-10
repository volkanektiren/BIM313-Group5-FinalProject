using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIM313_Group5_FinalProject.Models;
using BIM313_Group5_FinalProject.ChildComponents;

namespace BIM313_Group5_FinalProject
{
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author();
                author.firstName = textBox1.Text;
                author.lastName = textBox2.Text;

                authorsTableAdapter.Create(author.firstName, author.lastName);
                ViewAuthors.isChanged = true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewAuthors.isChanged = false;
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
