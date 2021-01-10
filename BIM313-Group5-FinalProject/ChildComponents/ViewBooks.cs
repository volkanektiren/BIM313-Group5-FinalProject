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
using BIM313_Group5_FinalProject.Util;

namespace BIM313_Group5_FinalProject.ChildComponents
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }
        public static bool isChanged { get; set; }
        private void ViewBooks_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.FillGrid(this.lMSDBDataSet.Books);
        }

        private void tbParameter_TextChanged(object sender, EventArgs e)
        {
            switch (cbSearchby.Text)
            {
                case "Title":
                    this.booksTableAdapter.FillByTitle(this.lMSDBDataSet.Books, tbParameter.Text);
                    break;
                case "Author":
                    this.booksTableAdapter.FillByAuthor(this.lMSDBDataSet.Books, tbParameter.Text, tbParameter.Text);
                    break;
                case "Genre":
                    this.booksTableAdapter.FillByGenre(this.lMSDBDataSet.Books, tbParameter.Text);
                    break;
                case "Publisher":
                    this.booksTableAdapter.FillByPublisher(this.lMSDBDataSet.Books, tbParameter.Text);
                    break;
                default:
                    break;
            }
            
        }

        private void addBookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddBook addBook = new AddBook();
                addBook.ShowDialog();

                if (isChanged)
                {
                    InformationForm information = new InformationForm("New book is added.", "Info");
                    information.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewBooks_Load(sender, e);
            }

        }

        private void editBookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditBook editBook = new EditBook();
                editBook.bookID = Int32.Parse(booksDataGridView.Rows[booksDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
                editBook.ShowDialog();

                InformationForm information = new InformationForm("Selected book is edited.", "Info");
                information.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewBooks_Load(sender, e);
            }

        }

        private void deleteBookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.DeleteBook(Int32.Parse(booksDataGridView.Rows[booksDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));

                InformationForm information = new InformationForm("Selected book is deleted.", "Info");
                information.Show();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.ViewBooks_Load(sender, e);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.ViewBooks_Load(sender, e);
        }
    }
}
