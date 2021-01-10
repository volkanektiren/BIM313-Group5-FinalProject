using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM313_Group5_FinalProject.ChildComponents
{
    public partial class Lends : Form
    {
        public Lends()
        {
            InitializeComponent();
        }

        private void Lends_Load(object sender, EventArgs e)
        {
            this.lendsTableAdapter.FillGrid(this.lMSDBDataSet.Lends);
        }

        private void tbParameter_TextChanged(object sender, EventArgs e)
        {
            switch (cbSearchby.Text)
            {
                case "Book Title":
                    this.lendsTableAdapter.FillByBookTitle(this.lMSDBDataSet.Lends, tbParameter.Text);
                    break;
                case "Visitor TCKN":
                    this.lendsTableAdapter.FillByVisitorTCKN(this.lMSDBDataSet.Lends, tbParameter.Text);
                    break;
                default:
                    break;
            }
        }

        private void lendBookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                LendBook lendBook = new LendBook();
                lendBook.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Lends_Load(sender, e);
            }
        }

        private void returnBookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.lendsTableAdapter.ReturnBook(Int32.Parse(lendsDataGridView.Rows[lendsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Lends_Load(sender, e);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.Lends_Load(sender, e);
        }
    }
}
