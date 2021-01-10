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

                InformationForm information = new InformationForm("A book is lent.", "Info");
                information.Show();
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
                int lendID = Int32.Parse(lendsDataGridView.Rows[lendsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
                int bookID = (int)lendsTableAdapter.FiilBookIDByLendID(lendID);
                this.lendsTableAdapter.ReturnBook(lendID);
                this.stocksTableAdapter.IncreaseNumber(bookID);

                InformationForm information = new InformationForm("Selected book is returned from selected visitor.", "Info");
                information.Show();
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            lendsTableAdapter.DecreaseTenancyBy1();
            lendsTableAdapter.AddPenaltyFee();

            DataTable lendIDs = lendsTableAdapter.GetLendIDsByTenancy(3);

            for(int i = 0; i<lendIDs.Rows.Count; i++)
            {
                int lendID = lendIDs.Rows[i].Field<int>("ID");
                string bookTitle = lendsTableAdapter.FillBookTitleByLendID(lendID);
                string visitorEmail = lendsTableAdapter.FillVisitorEmailByLendID(lendID);

                MailSender mailSender = new MailSender(bookTitle, visitorEmail);
            }
            
            this.Lends_Load(sender, e);
        }
    }
}
