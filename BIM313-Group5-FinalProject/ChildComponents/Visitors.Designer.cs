
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class Visitors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.visitorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorsTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.VisitorsTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            this.visitorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.deleteVisitorbtn = new System.Windows.Forms.Button();
            this.editVisitorbtn = new System.Windows.Forms.Button();
            this.addVisitorbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.cbSearchby = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorsBindingSource
            // 
            this.visitorsBindingSource.DataMember = "Visitors";
            this.visitorsBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // visitorsTableAdapter
            // 
            this.visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.LendsTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = this.visitorsTableAdapter;
            // 
            // visitorsDataGridView
            // 
            this.visitorsDataGridView.AllowUserToAddRows = false;
            this.visitorsDataGridView.AllowUserToDeleteRows = false;
            this.visitorsDataGridView.AllowUserToResizeColumns = false;
            this.visitorsDataGridView.AllowUserToResizeRows = false;
            this.visitorsDataGridView.AutoGenerateColumns = false;
            this.visitorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.visitorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visitorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.visitorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.visitorsDataGridView.DataSource = this.visitorsBindingSource;
            this.visitorsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.visitorsDataGridView.MultiSelect = false;
            this.visitorsDataGridView.Name = "visitorsDataGridView";
            this.visitorsDataGridView.ReadOnly = true;
            this.visitorsDataGridView.RowHeadersWidth = 62;
            this.visitorsDataGridView.RowTemplate.Height = 28;
            this.visitorsDataGridView.Size = new System.Drawing.Size(950, 700);
            this.visitorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TCKN";
            this.dataGridViewTextBoxColumn2.HeaderText = "TCKN";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 118;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 118;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 99;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshbtn.Location = new System.Drawing.Point(986, 418);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(282, 48);
            this.refreshbtn.TabIndex = 18;
            this.refreshbtn.Text = "Refrest All";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deleteVisitorbtn
            // 
            this.deleteVisitorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteVisitorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteVisitorbtn.Location = new System.Drawing.Point(986, 342);
            this.deleteVisitorbtn.Name = "deleteVisitorbtn";
            this.deleteVisitorbtn.Size = new System.Drawing.Size(282, 48);
            this.deleteVisitorbtn.TabIndex = 17;
            this.deleteVisitorbtn.Text = "Delete Selected Visitor";
            this.deleteVisitorbtn.UseVisualStyleBackColor = false;
            this.deleteVisitorbtn.Click += new System.EventHandler(this.deleteVisitorbtn_Click);
            // 
            // editVisitorbtn
            // 
            this.editVisitorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editVisitorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editVisitorbtn.Location = new System.Drawing.Point(986, 261);
            this.editVisitorbtn.Name = "editVisitorbtn";
            this.editVisitorbtn.Size = new System.Drawing.Size(282, 48);
            this.editVisitorbtn.TabIndex = 16;
            this.editVisitorbtn.Text = "Edit Selected Visitor";
            this.editVisitorbtn.UseVisualStyleBackColor = false;
            this.editVisitorbtn.Click += new System.EventHandler(this.editVisitorbtn_Click);
            // 
            // addVisitorbtn
            // 
            this.addVisitorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addVisitorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addVisitorbtn.Location = new System.Drawing.Point(985, 180);
            this.addVisitorbtn.Name = "addVisitorbtn";
            this.addVisitorbtn.Size = new System.Drawing.Size(282, 48);
            this.addVisitorbtn.TabIndex = 15;
            this.addVisitorbtn.Text = "Add Visitor";
            this.addVisitorbtn.UseVisualStyleBackColor = false;
            this.addVisitorbtn.Click += new System.EventHandler(this.addVisitorbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1081, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search By";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(985, 102);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 13;
            this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
            // 
            // cbSearchby
            // 
            this.cbSearchby.FormattingEnabled = true;
            this.cbSearchby.Items.AddRange(new object[] {
            "TCKN",
            "Name"});
            this.cbSearchby.Location = new System.Drawing.Point(985, 64);
            this.cbSearchby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearchby.Name = "cbSearchby";
            this.cbSearchby.Size = new System.Drawing.Size(282, 28);
            this.cbSearchby.TabIndex = 12;
            this.cbSearchby.Text = "TCKN";
            // 
            // Visitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.deleteVisitorbtn);
            this.Controls.Add(this.editVisitorbtn);
            this.Controls.Add(this.addVisitorbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.cbSearchby);
            this.Controls.Add(this.visitorsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitors";
            this.Load += new System.EventHandler(this.Visitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource visitorsBindingSource;
        private LMSDBDataSetTableAdapters.VisitorsTableAdapter visitorsTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView visitorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button deleteVisitorbtn;
        private System.Windows.Forms.Button editVisitorbtn;
        private System.Windows.Forms.Button addVisitorbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.ComboBox cbSearchby;
    }
}