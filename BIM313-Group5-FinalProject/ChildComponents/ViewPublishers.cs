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
    public partial class ViewPublishers : Form
    {
        public ViewPublishers()
        {
            InitializeComponent();
        }

        private void ViewPublishers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.lMSDBDataSet.Publishers);

        }

        private void doActionbtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Add Publisher":
                    try
                    {
                        Publisher publisher = new Publisher();
                        publisher.name = tbParameter.Text;

                        publishersTableAdapter.Create(publisher.name);
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("An errer occured while crud operation on database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.ViewPublishers_Load(sender, e);
                    }
                    break;
                case "Edit Selected Publisher Name":
                    try
                    {
                        Publisher publisher = new Publisher();
                        publisher.name = tbParameter.Text;

                        publishersTableAdapter.UpdatePublisher(publisher.name, Int32.Parse(publishersDataGridView.Rows[publishersDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
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
                        this.ViewPublishers_Load(sender, e);
                    }
                    break;
                case "Delete Selected Publisher":
                    try
                    {
                        this.publishersTableAdapter.DeletePublisher(Int32.Parse(publishersDataGridView.Rows[publishersDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.ViewPublishers_Load(sender, e);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
