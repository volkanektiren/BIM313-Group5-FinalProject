
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class ViewAuthors
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
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.authorsTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.AuthorsTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.deleteAuthorbtn = new System.Windows.Forms.Button();
            this.editAuthorbtn = new System.Windows.Forms.Button();
            this.addAuthorbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.AllowUserToAddRows = false;
            this.authorsDataGridView.AllowUserToDeleteRows = false;
            this.authorsDataGridView.AllowUserToResizeColumns = false;
            this.authorsDataGridView.AllowUserToResizeRows = false;
            this.authorsDataGridView.AutoGenerateColumns = false;
            this.authorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.authorsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.authorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.authorsDataGridView.DataSource = this.authorsBindingSource;
            this.authorsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.authorsDataGridView.MultiSelect = false;
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.ReadOnly = true;
            this.authorsDataGridView.RowHeadersWidth = 62;
            this.authorsDataGridView.RowTemplate.Height = 28;
            this.authorsDataGridView.Size = new System.Drawing.Size(950, 700);
            this.authorsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1052, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By Name";
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(985, 69);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 9;
            this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 118;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 118;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.refreshbtn.Location = new System.Drawing.Point(986, 405);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(282, 48);
            this.refreshbtn.TabIndex = 15;
            this.refreshbtn.Text = "Refrest All";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deleteAuthorbtn
            // 
            this.deleteAuthorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteAuthorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteAuthorbtn.Location = new System.Drawing.Point(986, 329);
            this.deleteAuthorbtn.Name = "deleteAuthorbtn";
            this.deleteAuthorbtn.Size = new System.Drawing.Size(282, 48);
            this.deleteAuthorbtn.TabIndex = 14;
            this.deleteAuthorbtn.Text = "Delete Selected Author";
            this.deleteAuthorbtn.UseVisualStyleBackColor = false;
            this.deleteAuthorbtn.Click += new System.EventHandler(this.deleteAuthorbtn_Click);
            // 
            // editAuthorbtn
            // 
            this.editAuthorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editAuthorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editAuthorbtn.Location = new System.Drawing.Point(986, 248);
            this.editAuthorbtn.Name = "editAuthorbtn";
            this.editAuthorbtn.Size = new System.Drawing.Size(282, 48);
            this.editAuthorbtn.TabIndex = 13;
            this.editAuthorbtn.Text = "Edit Selected Author";
            this.editAuthorbtn.UseVisualStyleBackColor = false;
            this.editAuthorbtn.Click += new System.EventHandler(this.editAuthorbtn_Click);
            // 
            // addAuthorbtn
            // 
            this.addAuthorbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAuthorbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addAuthorbtn.Location = new System.Drawing.Point(985, 167);
            this.addAuthorbtn.Name = "addAuthorbtn";
            this.addAuthorbtn.Size = new System.Drawing.Size(282, 48);
            this.addAuthorbtn.TabIndex = 12;
            this.addAuthorbtn.Text = "Add Author";
            this.addAuthorbtn.UseVisualStyleBackColor = false;
            this.addAuthorbtn.Click += new System.EventHandler(this.addAuthorbtn_Click);
            // 
            // ViewAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.deleteAuthorbtn);
            this.Controls.Add(this.editAuthorbtn);
            this.Controls.Add(this.addAuthorbtn);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAuthors";
            this.Load += new System.EventHandler(this.ViewAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LMSDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView authorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button deleteAuthorbtn;
        private System.Windows.Forms.Button editAuthorbtn;
        private System.Windows.Forms.Button addAuthorbtn;
    }
}