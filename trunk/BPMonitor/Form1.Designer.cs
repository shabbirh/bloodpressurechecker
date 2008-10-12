namespace Hassanally.Net.BPMonitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("January", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("February", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("March", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("April", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("May", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("June", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("July", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("August", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("September", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("October", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("November", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("December", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBloodPressureMonitorDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBloodPressureMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editThisEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createNewBPMonitorFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingBPMonitorFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBloodPressureMonitorDatabaseToolStripMenuItem,
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem,
            this.toolStripSeparator5,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBloodPressureMonitorDatabaseToolStripMenuItem
            // 
            this.newBloodPressureMonitorDatabaseToolStripMenuItem.Name = "newBloodPressureMonitorDatabaseToolStripMenuItem";
            this.newBloodPressureMonitorDatabaseToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.newBloodPressureMonitorDatabaseToolStripMenuItem.Text = "New Blood Pressure Monitor Database";
            this.newBloodPressureMonitorDatabaseToolStripMenuItem.Click += new System.EventHandler(this.newBloodPressureMonitorDatabaseToolStripMenuItem_Click);
            // 
            // openExistingBloodPressureMonitorDatabaseToolStripMenuItem
            // 
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem.Name = "openExistingBloodPressureMonitorDatabaseToolStripMenuItem";
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem.Text = "Open Existing Blood Pressure Monitor Database";
            this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(321, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(324, 22);
            this.toolStripMenuItem1.Text = "Quit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBloodPressureMonitorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutBloodPressureMonitorToolStripMenuItem
            // 
            this.aboutBloodPressureMonitorToolStripMenuItem.Name = "aboutBloodPressureMonitorToolStripMenuItem";
            this.aboutBloodPressureMonitorToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.aboutBloodPressureMonitorToolStripMenuItem.Text = "About Blood Pressure Monitor";
            this.aboutBloodPressureMonitorToolStripMenuItem.Click += new System.EventHandler(this.aboutBloodPressureMonitorToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "bpmdb";
            this.saveFileDialog1.Title = "Create New Blood Pressure Monitor File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "January";
            listViewGroup1.Name = "group";
            listViewGroup2.Header = "February";
            listViewGroup2.Name = "group2";
            listViewGroup3.Header = "March";
            listViewGroup3.Name = "group3";
            listViewGroup4.Header = "April";
            listViewGroup4.Name = "group4";
            listViewGroup5.Header = "May";
            listViewGroup5.Name = "group5";
            listViewGroup6.Header = "June";
            listViewGroup6.Name = "group6";
            listViewGroup7.Header = "July";
            listViewGroup7.Name = "group7";
            listViewGroup8.Header = "August";
            listViewGroup8.Name = "group8";
            listViewGroup9.Header = "September";
            listViewGroup9.Name = "group9";
            listViewGroup10.Header = "October";
            listViewGroup10.Name = "group10";
            listViewGroup11.Header = "November";
            listViewGroup11.Name = "group11";
            listViewGroup12.Header = "December";
            listViewGroup12.Name = "group12";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(731, 450);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date of Reading";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Blood Pressure Systolic/Diastolic (mmHg)";
            this.columnHeader2.Width = 343;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pulse Rate (bpm)";
            this.columnHeader3.Width = 242;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEntryToolStripMenuItem,
            this.toolStripSeparator2,
            this.editThisEntryToolStripMenuItem,
            this.deleteThisEntryToolStripMenuItem,
            this.toolStripSeparator3,
            this.createNewBPMonitorFileToolStripMenuItem,
            this.openExistingBPMonitorFileToolStripMenuItem,
            this.toolStripSeparator4,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 154);
            // 
            // addNewEntryToolStripMenuItem
            // 
            this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
            this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.addNewEntryToolStripMenuItem.Text = "Add New Entry";
            this.addNewEntryToolStripMenuItem.Click += new System.EventHandler(this.addNewEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // editThisEntryToolStripMenuItem
            // 
            this.editThisEntryToolStripMenuItem.Name = "editThisEntryToolStripMenuItem";
            this.editThisEntryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.editThisEntryToolStripMenuItem.Text = "Edit This Entry";
            this.editThisEntryToolStripMenuItem.Click += new System.EventHandler(this.editThisEntryToolStripMenuItem_Click);
            // 
            // deleteThisEntryToolStripMenuItem
            // 
            this.deleteThisEntryToolStripMenuItem.Name = "deleteThisEntryToolStripMenuItem";
            this.deleteThisEntryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.deleteThisEntryToolStripMenuItem.Text = "Delete This Entry";
            this.deleteThisEntryToolStripMenuItem.Click += new System.EventHandler(this.deleteThisEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // createNewBPMonitorFileToolStripMenuItem
            // 
            this.createNewBPMonitorFileToolStripMenuItem.Name = "createNewBPMonitorFileToolStripMenuItem";
            this.createNewBPMonitorFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.createNewBPMonitorFileToolStripMenuItem.Text = "Create New BP Monitor File";
            this.createNewBPMonitorFileToolStripMenuItem.Click += new System.EventHandler(this.createNewBPMonitorFileToolStripMenuItem_Click);
            // 
            // openExistingBPMonitorFileToolStripMenuItem
            // 
            this.openExistingBPMonitorFileToolStripMenuItem.Name = "openExistingBPMonitorFileToolStripMenuItem";
            this.openExistingBPMonitorFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openExistingBPMonitorFileToolStripMenuItem.Text = "Open Existing BP Monitor File";
            this.openExistingBPMonitorFileToolStripMenuItem.Click += new System.EventHandler(this.openExistingBPMonitorFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(227, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(218, 17);
            this.toolStripStatusLabel1.Text = "Welcome to the Blood Pressure Monitor";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(330, 191);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(324, 22);
            this.toolStripMenuItem2.Text = "Save Data as PDF Report ...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(321, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 504);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Blood Pressure Monitor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBloodPressureMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBloodPressureMonitorDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingBloodPressureMonitorDatabaseToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editThisEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createNewBPMonitorFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingBPMonitorFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

