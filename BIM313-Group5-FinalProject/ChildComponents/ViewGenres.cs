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

namespace BIM313_Group5_FinalProject.ChildComponents
{
    public partial class ViewGenres : Form
    {
        public ViewGenres()
        {
            InitializeComponent();
        }

        private void ViewGenres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.lMSDBDataSet.Genres);
        }

        private void doActionbtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Add Genre":
                    try
                    {
                        Genre genre = new Genre();
                        genre.name= tbParameter.Text;

                        genresTableAdapter.Create(genre.name);
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.ViewGenres_Load(sender, e);
                    }
                    break;
                case "Edit Selected Genre Name":
                    try
                    {
                        Genre genre = new Genre();
                        genre.name = tbParameter.Text;

                        genresTableAdapter.UpdateGenre(genre.name, Int32.Parse(genresDataGridView.Rows[genresDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a row to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.ViewGenres_Load(sender, e);
                    }
                    break;
                case "Delete Selected Genre":
                    try
                    {
                        this.genresTableAdapter.DeleteGenre(Int32.Parse(genresDataGridView.Rows[genresDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.ViewGenres_Load(sender, e);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
