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
    public partial class Visitors : Form
    {
        public Visitors()
        {
            InitializeComponent();
        }

        private void Visitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Visitors' table. You can move, or remove it, as needed.
            this.visitorsTableAdapter.Fill(this.lMSDBDataSet.Visitors);

        }

        private void tbParameter_TextChanged(object sender, EventArgs e)
        {
            switch (cbSearchby.Text)
            {
                case "TCKN":
                    this.visitorsTableAdapter.FillByTCKN(this.lMSDBDataSet.Visitors, tbParameter.Text);
                    break;
                case "Name":
                    this.visitorsTableAdapter.FillByName(this.lMSDBDataSet.Visitors, tbParameter.Text, tbParameter.Text);
                    break;
                default:
                    break;
            }
        }

        private void addVisitorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddVisitor addVisitor = new AddVisitor();
                addVisitor.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Visitors_Load(sender, e);
            }
        }

        private void editVisitorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                EditVisitor editVisitor = new EditVisitor();
                editVisitor.visitorID = Int32.Parse(visitorsDataGridView.Rows[visitorsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString());
                editVisitor.ShowDialog();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Visitors_Load(sender, e);
            }
        }

        private void deleteVisitorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.visitorsTableAdapter.DeleteVisitor(Int32.Parse(visitorsDataGridView.Rows[visitorsDataGridView.SelectedRows[0].Index].Cells[0].Value.ToString()));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a row first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Visitors_Load(sender, e);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            this.Visitors_Load(sender, e);
        }
    }
}
