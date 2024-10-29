namespace Medicine_Celler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryEditDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryEditDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertUpdateDeleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(813, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.medicineCategoryToolStripMenuItem,
            this.medicineInformationToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryEditDeleteToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.exitToolStripMenuItem.Text = "Medicine Company";
            // 
            // entryEditDeleteToolStripMenuItem
            // 
            this.entryEditDeleteToolStripMenuItem.Name = "entryEditDeleteToolStripMenuItem";
            this.entryEditDeleteToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.entryEditDeleteToolStripMenuItem.Text = "Entry/Edit/Delete";
            this.entryEditDeleteToolStripMenuItem.Click += new System.EventHandler(this.entryEditDeleteToolStripMenuItem_Click_1);
            // 
            // medicineCategoryToolStripMenuItem
            // 
            this.medicineCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryEditDeleteToolStripMenuItem1});
            this.medicineCategoryToolStripMenuItem.Name = "medicineCategoryToolStripMenuItem";
            this.medicineCategoryToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.medicineCategoryToolStripMenuItem.Text = "Medicine Category";
            // 
            // entryEditDeleteToolStripMenuItem1
            // 
            this.entryEditDeleteToolStripMenuItem1.Name = "entryEditDeleteToolStripMenuItem1";
            this.entryEditDeleteToolStripMenuItem1.Size = new System.Drawing.Size(238, 30);
            this.entryEditDeleteToolStripMenuItem1.Text = "Entry/Edit/Delete";
            this.entryEditDeleteToolStripMenuItem1.Click += new System.EventHandler(this.entryEditDeleteToolStripMenuItem1_Click_1);
            // 
            // medicineInformationToolStripMenuItem1
            // 
            this.medicineInformationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem});
            this.medicineInformationToolStripMenuItem1.Name = "medicineInformationToolStripMenuItem1";
            this.medicineInformationToolStripMenuItem1.Size = new System.Drawing.Size(245, 30);
            this.medicineInformationToolStripMenuItem1.Text = "Purchase Info";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.entryToolStripMenuItem.Text = "Entry";
            this.entryToolStripMenuItem.Click += new System.EventHandler(this.entryToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(245, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertUpdateDeleteToolStripMenuItem2});
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.medicineToolStripMenuItem.Text = "Master-Details";
            // 
            // insertUpdateDeleteToolStripMenuItem2
            // 
            this.insertUpdateDeleteToolStripMenuItem2.Name = "insertUpdateDeleteToolStripMenuItem2";
            this.insertUpdateDeleteToolStripMenuItem2.Size = new System.Drawing.Size(130, 30);
            this.insertUpdateDeleteToolStripMenuItem2.Text = "Show";
            this.insertUpdateDeleteToolStripMenuItem2.Click += new System.EventHandler(this.insertUpdateDeleteToolStripMenuItem2_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineInformationToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // medicineInformationToolStripMenuItem
            // 
            this.medicineInformationToolStripMenuItem.Name = "medicineInformationToolStripMenuItem";
            this.medicineInformationToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.medicineInformationToolStripMenuItem.Text = "Medicine Information";
            this.medicineInformationToolStripMenuItem.Click += new System.EventHandler(this.medicineInformationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 518);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryEditDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryEditDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicineInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertUpdateDeleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

