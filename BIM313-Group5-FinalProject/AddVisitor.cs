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

namespace BIM313_Group5_FinalProject
{
    public partial class AddVisitor : Form
    {
        public AddVisitor()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Visitor visitor = new Visitor();
                visitor.TCKN = textBox1.Text;
                visitor.firstName = textBox2.Text;
                visitor.lastName = textBox3.Text;

                if (radioButton1.Checked) visitor.gender = radioButton1.Text;
                else if (radioButton2.Checked) visitor.gender = radioButton2.Text;
                else visitor.gender = radioButton3.Text;

                visitor.age = (short)numericUpDown1.Value;
                visitor.email = textBox4.Text;

                visitorsTableAdapter.Create(visitor.TCKN, visitor.firstName, visitor.lastName, visitor.gender, visitor.age, visitor.email);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
