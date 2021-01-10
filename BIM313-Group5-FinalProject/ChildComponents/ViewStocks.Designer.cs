
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class ViewStocks
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
            this.refreshbtn = new System.Windows.Forms.Button();
            this.deleteRecordbtn = new System.Windows.Forms.Button();
            this.editRecordbtn = new System.Windows.Forms.Button();
            this.addStockRecordbtn = new System.Windows.Forms.Button();
            this.stocksDataGridView = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.stocksTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.StocksTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshbtn.Location = new System.Drawing.Point(986, 403);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(282, 48);
            this.refreshbtn.TabIndex = 20;
            this.refreshbtn.Text = "Refresh All";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deleteRecordbtn
            // 
            this.deleteRecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteRecordbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteRecordbtn.Location = new System.Drawing.Point(986, 327);
            this.deleteRecordbtn.Name = "deleteRecordbtn";
            this.deleteRecordbtn.Size = new System.Drawing.Size(282, 48);
            this.deleteRecordbtn.TabIndex = 19;
            this.deleteRecordbtn.Text = "Delete Selected Record";
            this.deleteRecordbtn.UseVisualStyleBackColor = false;
            this.deleteRecordbtn.Click += new System.EventHandler(this.deleteRecordbtn_Click);
            // 
            // editRecordbtn
            // 
            this.editRecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editRecordbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editRecordbtn.Location = new System.Drawing.Point(986, 246);
            this.editRecordbtn.Name = "editRecordbtn";
            this.editRecordbtn.Size = new System.Drawing.Size(282, 48);
            this.editRecordbtn.TabIndex = 18;
            this.editRecordbtn.Text = "Edit Selected Record";
            this.editRecordbtn.UseVisualStyleBackColor = false;
            this.editRecordbtn.Click += new System.EventHandler(this.editRecordbtn_Click);
            // 
            // addStockRecordbtn
            // 
            this.addStockRecordbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addStockRecordbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addStockRecordbtn.Location = new System.Drawing.Point(985, 165);
            this.addStockRecordbtn.Name = "addStockRecordbtn";
            this.addStockRecordbtn.Size = new System.Drawing.Size(282, 48);
            this.addStockRecordbtn.TabIndex = 17;
            this.addStockRecordbtn.Text = "New Stock Record";
            this.addStockRecordbtn.UseVisualStyleBackColor = false;
            this.addStockRecordbtn.Click += new System.EventHandler(this.addStockRecordbtn_Click);
            // 
            // stocksDataGridView
            // 
            this.stocksDataGridView.AllowUserToAddRows = false;
            this.stocksDataGridView.AllowUserToDeleteRows = false;
            this.stocksDataGridView.AllowUserToResizeColumns = false;
            this.stocksDataGridView.AllowUserToResizeRows = false;
            this.stocksDataGridView.AutoGenerateColumns = false;
            this.stocksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stocksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stocksDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.stocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.numberDataGridViewTextBoxColumn});
            this.stocksDataGridView.DataSource = this.stocksBindingSource;
            this.stocksDataGridView.Location = new System.Drawing.Point(12, 10);
            this.stocksDataGridView.MultiSelect = false;
            this.stocksDataGridView.Name = "stocksDataGridView";
            this.stocksDataGridView.ReadOnly = true;
            this.stocksDataGridView.RowHeadersWidth = 62;
            this.stocksDataGridView.RowTemplate.Height = 28;
            this.stocksDataGridView.Size = new System.Drawing.Size(950, 700);
            this.stocksDataGridView.TabIndex = 16;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Width = 99;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 101;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.LendsTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = this.stocksTableAdapter;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = null;
            // 
            // ViewStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.deleteRecordbtn);
            this.Controls.Add(this.editRecordbtn);
            this.Controls.Add(this.addStockRecordbtn);
            this.Controls.Add(this.stocksDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStocks";
            this.Load += new System.EventHandler(this.ViewStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button deleteRecordbtn;
        private System.Windows.Forms.Button editRecordbtn;
        private System.Windows.Forms.Button addStockRecordbtn;
        private System.Windows.Forms.DataGridView stocksDataGridView;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private LMSDBDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    }
}