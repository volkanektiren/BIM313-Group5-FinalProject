
namespace BIM313_Group5_FinalProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPublishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.lendsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.minimizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 51);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripMenuItem,
            this.viewAuthorsToolStripMenuItem,
            this.viewGenresToolStripMenuItem,
            this.viewPublishersToolStripMenuItem,
            this.viewStocksToolStripMenuItem});
            this.bookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookToolStripMenuItem.Image")));
            this.bookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(116, 47);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBooksToolStripMenuItem.Image")));
            this.viewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(319, 64);
            this.viewBooksToolStripMenuItem.Text = "View Books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // viewAuthorsToolStripMenuItem
            // 
            this.viewAuthorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAuthorsToolStripMenuItem.Image")));
            this.viewAuthorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewAuthorsToolStripMenuItem.Name = "viewAuthorsToolStripMenuItem";
            this.viewAuthorsToolStripMenuItem.Size = new System.Drawing.Size(285, 64);
            this.viewAuthorsToolStripMenuItem.Text = "View Authors";
            this.viewAuthorsToolStripMenuItem.Click += new System.EventHandler(this.viewAuthorsToolStripMenuItem_Click);
            // 
            // viewPublishersToolStripMenuItem
            // 
            this.viewPublishersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewPublishersToolStripMenuItem.Image")));
            this.viewPublishersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewPublishersToolStripMenuItem.Name = "viewPublishersToolStripMenuItem";
            this.viewPublishersToolStripMenuItem.Size = new System.Drawing.Size(285, 64);
            this.viewPublishersToolStripMenuItem.Text = "View Publishers";
            this.viewPublishersToolStripMenuItem.Click += new System.EventHandler(this.viewPublishersToolStripMenuItem_Click);
            // 
            // viewGenresToolStripMenuItem
            // 
            this.viewGenresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewGenresToolStripMenuItem.Image")));
            this.viewGenresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewGenresToolStripMenuItem.Name = "viewGenresToolStripMenuItem";
            this.viewGenresToolStripMenuItem.Size = new System.Drawing.Size(285, 64);
            this.viewGenresToolStripMenuItem.Text = "View Genres";
            this.viewGenresToolStripMenuItem.Click += new System.EventHandler(this.viewGenresToolStripMenuItem_Click);
            // 
            // viewStocksToolStripMenuItem
            // 
            this.viewStocksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStocksToolStripMenuItem.Image")));
            this.viewStocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStocksToolStripMenuItem.Name = "viewStocksToolStripMenuItem";
            this.viewStocksToolStripMenuItem.Size = new System.Drawing.Size(285, 64);
            this.viewStocksToolStripMenuItem.Text = "View Stocks";
            this.viewStocksToolStripMenuItem.Click += new System.EventHandler(this.viewStocksToolStripMenuItem_Click);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.visitorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visitorToolStripMenuItem.Image")));
            this.visitorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(136, 47);
            this.visitorToolStripMenuItem.Text = "Visitors";
            this.visitorToolStripMenuItem.Click += new System.EventHandler(this.visitorToolStripMenuItem_Click);
            // 
            // lendsToolStripMenuItem
            // 
            this.lendsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lendsToolStripMenuItem.Image")));
            this.lendsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lendsToolStripMenuItem.Name = "lendsToolStripMenuItem";
            this.lendsToolStripMenuItem.Size = new System.Drawing.Size(127, 49);
            this.lendsToolStripMenuItem.Text = "Lends";
            this.lendsToolStripMenuItem.Click += new System.EventHandler(this.lendsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 49);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToolStripMenuItem.Image")));
            this.minimizeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(149, 49);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPublishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStocksToolStripMenuItem;
    }
}