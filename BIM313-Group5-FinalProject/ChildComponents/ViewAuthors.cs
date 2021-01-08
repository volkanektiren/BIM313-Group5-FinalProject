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
    public partial class ViewAuthors : Form
    {
        public ViewAuthors()
        {
            InitializeComponent();
        }

        private void ViewAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                this.authorsTableAdapter.Fill(this.lMSDBDataSet.Authors);
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbParameter_TextChanged(object sender, EventArgs e)
        {
            this.authorsTableAdapter.FillByFirstOrLastName(this.lMSDBDataSet.Authors, tbParameter.Text, tbParameter.Text);
        }

        private void addAuthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddAuthor addAuthor = new AddAuthor();
                addAuthor.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewAuthors_Load(sender, e);
            }
        }

        private void editAuthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditAuthor editAuthor = new EditAuthor();
                editAuthor.authorID = Int32.Parse(authorsDataGridView.Rows[authorsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
                editAuthor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewAuthors_Load(sender, e);
            }
        }

        private void deleteAuthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.authorsTableAdapter.DeleteAuthor(Int32.Parse(authorsDataGridView.Rows[authorsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewAuthors_Load(sender, e);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.ViewAuthors_Load(sender, e);
        }
    }
}
