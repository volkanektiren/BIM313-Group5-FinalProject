
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class Lends
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
            this.lendsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.cbSearchby = new System.Windows.Forms.ComboBox();
            this.lendBookbtn = new System.Windows.Forms.Button();
            this.returnBookbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.lendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.lendsTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.LendsTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PenaltyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lendsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lendsDataGridView
            // 
            this.lendsDataGridView.AllowUserToAddRows = false;
            this.lendsDataGridView.AllowUserToDeleteRows = false;
            this.lendsDataGridView.AllowUserToResizeColumns = false;
            this.lendsDataGridView.AllowUserToResizeRows = false;
            this.lendsDataGridView.AutoGenerateColumns = false;
            this.lendsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lendsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lendsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Book,
            this.Visitor,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.PenaltyFee});
            this.lendsDataGridView.DataSource = this.lendsBindingSource;
            this.lendsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.lendsDataGridView.MultiSelect = false;
            this.lendsDataGridView.Name = "lendsDataGridView";
            this.lendsDataGridView.ReadOnly = true;
            this.lendsDataGridView.RowHeadersWidth = 62;
            this.lendsDataGridView.RowTemplate.Height = 28;
            this.lendsDataGridView.Size = new System.Drawing.Size(950, 696);
            this.lendsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1071, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search By";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(975, 98);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 9;
            this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
            // 
            // cbSearchby
            // 
            this.cbSearchby.FormattingEnabled = true;
            this.cbSearchby.Items.AddRange(new object[] {
            "Book Title",
            "Visitor TCKN"});
            this.cbSearchby.Location = new System.Drawing.Point(975, 60);
            this.cbSearchby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearchby.Name = "cbSearchby";
            this.cbSearchby.Size = new System.Drawing.Size(282, 28);
            this.cbSearchby.TabIndex = 8;
            this.cbSearchby.Text = "Book Title";
            // 
            // lendBookbtn
            // 
            this.lendBookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lendBookbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.lendBookbtn.Location = new System.Drawing.Point(975, 169);
            this.lendBookbtn.Name = "lendBookbtn";
            this.lendBookbtn.Size = new System.Drawing.Size(282, 48);
            this.lendBookbtn.TabIndex = 11;
            this.lendBookbtn.Text = "Lend Book";
            this.lendBookbtn.UseVisualStyleBackColor = false;
            this.lendBookbtn.Click += new System.EventHandler(this.lendBookbtn_Click);
            // 
            // returnBookbtn
            // 
            this.returnBookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.returnBookbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.returnBookbtn.Location = new System.Drawing.Point(975, 246);
            this.returnBookbtn.Name = "returnBookbtn";
            this.returnBookbtn.Size = new System.Drawing.Size(282, 48);
            this.returnBookbtn.TabIndex = 12;
            this.returnBookbtn.Text = "Return Book";
            this.returnBookbtn.UseVisualStyleBackColor = false;
            this.returnBookbtn.Click += new System.EventHandler(this.returnBookbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshbtn.Location = new System.Drawing.Point(975, 327);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(282, 48);
            this.refreshbtn.TabIndex = 13;
            this.refreshbtn.Text = "Refresh All";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // lendsBindingSource
            // 
            this.lendsBindingSource.DataMember = "Lends";
            this.lendsBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendsTableAdapter
            // 
            this.lendsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.LendsTableAdapter = this.lendsTableAdapter;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = null;
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
            // Book
            // 
            this.Book.DataPropertyName = "Book";
            this.Book.HeaderText = "Book";
            this.Book.MinimumWidth = 8;
            this.Book.Name = "Book";
            this.Book.ReadOnly = true;
            this.Book.Width = 82;
            // 
            // Visitor
            // 
            this.Visitor.DataPropertyName = "Visitor";
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.MinimumWidth = 8;
            this.Visitor.Name = "Visitor";
            this.Visitor.ReadOnly = true;
            this.Visitor.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LendDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "LendDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 116;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tenancy";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tenancy";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "State";
            this.dataGridViewCheckBoxColumn1.HeaderText = "State";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 54;
            // 
            // PenaltyFee
            // 
            this.PenaltyFee.DataPropertyName = "PenaltyFee";
            this.PenaltyFee.HeaderText = "PenaltyFee";
            this.PenaltyFee.MinimumWidth = 8;
            this.PenaltyFee.Name = "PenaltyFee";
            this.PenaltyFee.ReadOnly = true;
            this.PenaltyFee.Width = 125;
            // 
            // Lends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.returnBookbtn);
            this.Controls.Add(this.lendBookbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.cbSearchby);
            this.Controls.Add(this.lendsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lends";
            this.Load += new System.EventHandler(this.Lends_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lendsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource lendsBindingSource;
        private LMSDBDataSetTableAdapters.LendsTableAdapter lendsTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lendsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.ComboBox cbSearchby;
        private System.Windows.Forms.Button lendBookbtn;
        private System.Windows.Forms.Button returnBookbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyFee;
    }
}