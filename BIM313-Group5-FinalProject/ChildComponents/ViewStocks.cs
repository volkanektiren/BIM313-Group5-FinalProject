using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIM313_Group5_FinalProject.Util;

namespace BIM313_Group5_FinalProject.ChildComponents
{
    public partial class ViewStocks : Form
    {
        public ViewStocks()
        {
            InitializeComponent();
        }

        private void ViewStocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.lMSDBDataSet.Stocks);

        }

        private void addStockRecordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                NewRecord newRecord = new NewRecord();
                newRecord.ShowDialog();

                InformationForm information = new InformationForm("New stock record is added.", "Info");
                information.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewStocks_Load(sender, e);
            }
        }

        private void editRecordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditStock editStock = new EditStock();
                editStock.bookID = Int32.Parse(stocksDataGridView.Rows[stocksDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
                editStock.ShowDialog();

                InformationForm information = new InformationForm("Selected stock record is edited.", "Info");
                information.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewStocks_Load(sender, e);
            }
        }

        private void deleteRecordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.stocksTableAdapter.DeleteStock(Int32.Parse(stocksDataGridView.Rows[stocksDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));

                InformationForm information = new InformationForm("Selected stock record is deleted.", "Info");
                information.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewStocks_Load(sender, e);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.ViewStocks_Load(sender, e);
        }
    }
}
