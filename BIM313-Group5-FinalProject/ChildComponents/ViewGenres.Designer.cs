
namespace BIM313_Group5_FinalProject.ChildComponents
{
    partial class ViewGenres
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
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.GenresTableAdapter();
            this.tableAdapterManager = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager();
            this.genresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbParameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doActionbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenresTableAdapter = this.genresTableAdapter;
            this.tableAdapterManager.LendsTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.StocksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorsTableAdapter = null;
            // 
            // genresDataGridView
            // 
            this.genresDataGridView.AllowUserToAddRows = false;
            this.genresDataGridView.AllowUserToDeleteRows = false;
            this.genresDataGridView.AllowUserToResizeColumns = false;
            this.genresDataGridView.AllowUserToResizeRows = false;
            this.genresDataGridView.AutoGenerateColumns = false;
            this.genresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.genresDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.genresDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.genresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.genresDataGridView.DataSource = this.genresBindingSource;
            this.genresDataGridView.Location = new System.Drawing.Point(12, 12);
            this.genresDataGridView.MultiSelect = false;
            this.genresDataGridView.Name = "genresDataGridView";
            this.genresDataGridView.ReadOnly = true;
            this.genresDataGridView.RowHeadersWidth = 62;
            this.genresDataGridView.RowTemplate.Height = 28;
            this.genresDataGridView.Size = new System.Drawing.Size(950, 700);
            this.genresDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GenreName";
            this.dataGridViewTextBoxColumn2.HeaderText = "GenreName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 132;
            // 
            // tbParameter
            // 
            this.tbParameter.Location = new System.Drawing.Point(985, 97);
            this.tbParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbParameter.Name = "tbParameter";
            this.tbParameter.Size = new System.Drawing.Size(282, 26);
            this.tbParameter.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1052, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select an Action";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add Genre",
            "Edit Selected Genre Name",
            "Delete Selected Genre"});
            this.comboBox1.Location = new System.Drawing.Point(985, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Add Genre";
            // 
            // doActionbtn
            // 
            this.doActionbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doActionbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.doActionbtn.Location = new System.Drawing.Point(986, 147);
            this.doActionbtn.Name = "doActionbtn";
            this.doActionbtn.Size = new System.Drawing.Size(282, 48);
            this.doActionbtn.TabIndex = 13;
            this.doActionbtn.Text = "Do Chosen Action";
            this.doActionbtn.UseVisualStyleBackColor = false;
            this.doActionbtn.Click += new System.EventHandler(this.doActionbtn_Click);
            // 
            // ViewGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.doActionbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbParameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genresDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewGenres";
            this.Load += new System.EventHandler(this.ViewGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private LMSDBDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private LMSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView genresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tbParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button doActionbtn;
    }
}