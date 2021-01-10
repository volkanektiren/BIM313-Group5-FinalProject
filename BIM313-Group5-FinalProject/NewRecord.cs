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
    public partial class NewRecord : Form
    {
        public NewRecord()
        {
            InitializeComponent();
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.lMSDBDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.bookID = (int)comboBox1.SelectedValue;
                stock.number = (short)numericUpDown1.Value;

                stocksTableAdapter.Create(stock.number, stock.bookID);
                ViewStocks.isChanged = true;
            }
            catch(System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("A stock record for this book already exist! Record declined...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewStocks.isChanged = false;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewStocks.isChanged = false;
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
