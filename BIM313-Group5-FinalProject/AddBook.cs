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
using BIM313_Group5_FinalProject.ChildComponents;

namespace BIM313_Group5_FinalProject
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            try
            {
                this.publishersTableAdapter.Fill(this.lMSDBDataSet.Publishers);
                this.genresTableAdapter.Fill(this.lMSDBDataSet.Genres);
                this.authorsTableAdapter.Fill(this.lMSDBDataSet.Authors);
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

                booksTableAdapter.Create(book.title, book.publicationYear, book.pageNumber, book.authorID, book.genreID, book.publisherID);
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
