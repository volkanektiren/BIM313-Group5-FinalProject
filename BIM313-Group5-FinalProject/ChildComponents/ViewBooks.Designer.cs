
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class ViewBooks
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
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.cbSearchby = new System.Windows.Forms.ComboBox();
            this.addBookbtn = new System.Windows.Forms.Button();
            this.editBookbtn = new System.Windows.Forms.Button();
            this.deleteBookbtn = new System.Windows.Forms.Button();
            this.booksTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AllowUserToResizeColumns = false;
            this.booksDataGridView.AllowUserToResizeRows = false;
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.booksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 12);
            this.booksDataGridView.MultiSelect = false;
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.RowHeadersWidth = 62;
            this.booksDataGridView.RowTemplate.Height = 28;
            this.booksDataGridView.Size = new System.Drawing.Size(950, 700);
            this.booksDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PublicationYear";
            this.dataGridViewTextBoxColumn3.HeaderText = "Publication Year";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PageNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number of Pages";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 114;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn5.HeaderText = "Author";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GenreName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PublisherName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(985, 102);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 6;
            this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
            // 
            // cbSearchby
            // 
            this.cbSearchby.FormattingEnabled = true;
            this.cbSearchby.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Genre",
            "Publisher"});
            this.cbSearchby.Location = new System.Drawing.Point(985, 64);
            this.cbSearchby.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearchby.Name = "cbSearchby";
            this.cbSearchby.Size = new System.Drawing.Size(282, 28);
            this.cbSearchby.TabIndex = 5;
            this.cbSearchby.Text = "Title";
            // 
            // addBookbtn
            // 
            this.addBookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBookbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBookbtn.Location = new System.Drawing.Point(985, 180);
            this.addBookbtn.Name = "addBookbtn";
            this.addBookbtn.Size = new System.Drawing.Size(282, 48);
            this.addBookbtn.TabIndex = 8;
            this.addBookbtn.Text = "Add Book";
            this.addBookbtn.UseVisualStyleBackColor = false;
            this.addBookbtn.Click += new System.EventHandler(this.addBookbtn_Click);
            // 
            // editBookbtn
            // 
            this.editBookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editBookbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editBookbtn.Location = new System.Drawing.Point(986, 261);
            this.editBookbtn.Name = "editBookbtn";
            this.editBookbtn.Size = new System.Drawing.Size(282, 48);
            this.editBookbtn.TabIndex = 9;
            this.editBookbtn.Text = "Edit Selected Book";
            this.editBookbtn.UseVisualStyleBackColor = false;
            this.editBookbtn.Click += new System.EventHandler(this.editBookbtn_Click);
            // 
            // deleteBookbtn
            // 
            this.deleteBookbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteBookbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBookbtn.Location = new System.Drawing.Point(986, 342);
            this.deleteBookbtn.Name = "deleteBookbtn";
            this.deleteBookbtn.Size = new System.Drawing.Size(282, 48);
            this.deleteBookbtn.TabIndex = 10;
            this.deleteBookbtn.Text = "Delete Selected Book";
            this.deleteBookbtn.UseVisualStyleBackColor = false;
            this.deleteBookbtn.Click += new System.EventHandler(this.deleteBookbtn_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.LendsTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = null;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshbtn.Location = new System.Drawing.Point(986, 418);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(282, 48);
            this.refreshbtn.TabIndex = 11;
            this.refreshbtn.Text = "Refrest All";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.deleteBookbtn);
            this.Controls.Add(this.editBookbtn);
            this.Controls.Add(this.addBookbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.cbSearchby);
            this.Controls.Add(this.booksDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LMSDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.ComboBox cbSearchby;
        private System.Windows.Forms.Button addBookbtn;
        private System.Windows.Forms.Button editBookbtn;
        private System.Windows.Forms.Button deleteBookbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}