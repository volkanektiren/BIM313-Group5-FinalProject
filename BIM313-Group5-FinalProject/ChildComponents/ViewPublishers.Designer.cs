
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class ViewPublishers
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
            this.label1 = new System.Windows.Forms.Label();
            this.doActionbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.publishersDataGridView = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.publishersTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.PublishersTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUBLISHERS";
            // 
            // doActionbtn
            // 
            this.doActionbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doActionbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.doActionbtn.Location = new System.Drawing.Point(986, 145);
            this.doActionbtn.Name = "doActionbtn";
            this.doActionbtn.Size = new System.Drawing.Size(282, 48);
            this.doActionbtn.TabIndex = 18;
            this.doActionbtn.Text = "Do Chosen Action";
            this.doActionbtn.UseVisualStyleBackColor = false;
            this.doActionbtn.Click += new System.EventHandler(this.doActionbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add Publisher",
            "Edit Selected Publisher Name",
            "Delete Selected Publisher"});
            this.comboBox1.Location = new System.Drawing.Point(985, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Add Publisher";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(985, 95);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1052, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select an Action";
            // 
            // publishersDataGridView
            // 
            this.publishersDataGridView.AllowUserToAddRows = false;
            this.publishersDataGridView.AllowUserToDeleteRows = false;
            this.publishersDataGridView.AllowUserToResizeColumns = false;
            this.publishersDataGridView.AllowUserToResizeRows = false;
            this.publishersDataGridView.AutoGenerateColumns = false;
            this.publishersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.publishersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.publishersDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.publishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn});
            this.publishersDataGridView.DataSource = this.publishersBindingSource;
            this.publishersDataGridView.Location = new System.Drawing.Point(12, 10);
            this.publishersDataGridView.MultiSelect = false;
            this.publishersDataGridView.Name = "publishersDataGridView";
            this.publishersDataGridView.ReadOnly = true;
            this.publishersDataGridView.RowHeadersWidth = 62;
            this.publishersDataGridView.RowTemplate.Height = 28;
            this.publishersDataGridView.Size = new System.Drawing.Size(950, 700);
            this.publishersDataGridView.TabIndex = 14;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 62;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName";
            this.publisherNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            this.publisherNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherNameDataGridViewTextBoxColumn.Width = 152;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.LendsTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = this.publishersTableAdapter;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = null;
            // 
            // ViewPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.doActionbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publishersDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPublishers";
            this.Load += new System.EventHandler(this.ViewPublishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doActionbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView publishersDataGridView;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LMSDBDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
    }
}