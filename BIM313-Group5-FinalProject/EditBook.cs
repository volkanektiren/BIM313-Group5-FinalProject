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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        public int bookID { get; set; }

        private void EditBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.lMSDBDataSet.Publishers);
            // TODO: This line of code loads data into the 'lMSDBDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.lMSDBDataSet.Genres);
            // TODO: This line of code loads data into the 'lMSDBDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.lMSDBDataSet.Authors);
            this.booksTableAdapter.FillByBookID(this.lMSDBDataSet.Books, this.bookID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.title = textBox1.Text;
                book.publicationYear = dateTimePicker1.Value.Date;
                book.pageNumber = (short)numericUpDown1.Value;
                book.authorID = (int)comboBox1.SelectedValue;
                book.genreID = (int)comboBox2.SelectedValue;
                book.publisherID = (int)comboBox3.SelectedValue;

                booksTableAdapter.UpdateBook(book.title, book.publicationYear, book.pageNumber, book.authorID, book.genreID, book.publisherID, this.bookID);
                ViewBooks.isChanged = true;
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBooks.isChanged = false;
            }
            finally
            {
                this.Dispose();
            }
        }
    }
}
