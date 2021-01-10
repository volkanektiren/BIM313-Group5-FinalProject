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
    public partial class LendBook : Form
    {
        public LendBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Lend lend = new Lend();
                lend.bookID = (int)comboBox1.SelectedValue;
                lend.visitorID = (int)comboBox2.SelectedValue;
                lend.lendDate = DateTime.Now.Date;
                lend.tenancy = (short)(booksTableAdapter.FillPageNumberByID(lend.bookID)/5);
                lend.state = false;
                lend.penaltyFee = 0;

                if (lendsTableAdapter.IsExist(lend.bookID, lend.visitorID) == 0)
                {
                    if ((int)lendsTableAdapter.CountNotReturnedLendsByVisitorID(lend.visitorID) < 3)
                    {
                        if (stocksTableAdapter.GetStockByBookID(lend.bookID) != 0)
                        {
                            lendsTableAdapter.Create(lend.bookID, lend.visitorID, lend.lendDate, lend.tenancy, lend.state, lend.penaltyFee);
                            stocksTableAdapter.DecreaseNumber(lend.bookID);
                            Lends.isChanged = true;
                        }
                        else
                        {
                            MessageBox.Show("This book is out of stocks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Lends.isChanged = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A visitor can currently lend at most 3 books!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lends.isChanged = false;
                    }
                }
                else
                {
                    MessageBox.Show("This visitor has already lent the book and not returned back yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lends.isChanged = false;
                }
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An error occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lends.isChanged = false;
            }
            finally
            {
                this.Dispose();
            }
        }

        private void LendBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Visitors' table. You can move, or remove it, as needed.
            this.visitorsTableAdapter.Fill(this.lMSDBDataSet.Visitors);
            // TODO: This line of code loads data into the 'lMSDBDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.lMSDBDataSet.Books);

        }
    }
}
