
namespace BIM313_Group5_FinalProject
{
    partial class NewRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.booksTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.BooksTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.stocksTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.StocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Books In Stock";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.booksBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(275, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 318);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRecord";
            this.Text = "New Record";
            this.Load += new System.EventHandler(this.NewRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LMSDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private LMSDBDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
    }
}