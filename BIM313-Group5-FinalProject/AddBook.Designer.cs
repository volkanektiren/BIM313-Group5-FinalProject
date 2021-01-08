
namespace BIM313_Group5_FinalProject
{
    partial class AddBook
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new BIM313_Group5_FinalProject.LMSDBDataSet();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.authorsTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.AuthorsTableAdapter();
            this.genresTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.GenresTableAdapter();
            this.publishersTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.PublishersTableAdapter();
            this.booksTableAdapter = new BIM313_Group5_FinalProject.LMSDBDataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Publication Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Pages";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 172);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(317, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.authorsBindingSource;
            this.comboBox1.DisplayMember = "Author";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "ID";
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
            // comboBox3
            // 
            this.comboBox3.DataSource = this.publishersBindingSource;
            this.comboBox3.DisplayMember = "PublisherName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 369);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(317, 28);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "ID";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.genresBindingSource;
            this.comboBox2.DisplayMember = "GenreName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 305);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(317, 28);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "ID";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Publisher";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LMSDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private LMSDBDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LMSDBDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private LMSDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
    }
}