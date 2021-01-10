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
    public partial class EditStock : Form
    {
        public EditStock()
        {
            InitializeComponent();
        }

        public int bookID { get; set; }
        private void EditStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.FillByBookID(this.lMSDBDataSet.Stocks, this.bookID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stock = new Stock();
                stock.number = (short)numericUpDown1.Value;

                stocksTableAdapter.UpdateStock(stock.number, this.bookID);
                ViewStocks.isChanged = true;
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
