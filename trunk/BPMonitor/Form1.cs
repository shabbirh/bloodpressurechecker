using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hassanally.Net;
using System.IO;
using Hassanally.Net.XMLDataLayer;
using System.Threading;
using System.Diagnostics;


namespace Hassanally.Net.BPMonitor
{
    public partial class Form1 : Form
    {
        DBHelper dataLayer = new DBHelper();
        DirSettingsHelper dirHelper = new DirSettingsHelper();

        string fileToOpen = "";

        public Form1()
        {
            InitializeComponent();
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);

            if (fileToOpen == "")
            {
                contextMenuStrip1.Items["editThisEntryToolStripMenuItem"].Enabled = false;
                contextMenuStrip1.Items["deleteThisEntryToolStripMenuItem"].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items["editThisEntryToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["deleteThisEntryToolStripMenuItem"].Enabled = true;
            }
        }

        public void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
            object sender = null;
            EventArgs e = null;
            if (sp.splashCommand == "open")
            {
                openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click(sender, e);
            }
            else
            {
                createNewBPMonitorFileToolStripMenuItem_Click(sender, e);
            }
        }

        private void aboutBloodPressureMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void newBloodPressureMonitorDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog1.Filter = "Blood Pressure Monitor Files|*.bpmdb";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(saveFileDialog1.FileName);

                if (fi.Exists)
                {
                    fi.Delete();
                }


                dataLayer.m_strDBPath = saveFileDialog1.FileName;
                dataLayer.CreateDB();

                toolStripStatusLabel1.Text = "Current Blood Pressure Monitor File: " + saveFileDialog1.FileName + " (New)";

                dataLayer.m_strDBPath = Path.GetDirectoryName(saveFileDialog1.FileName.ToString());
                dirHelper.SetDBDirPath(dataLayer.m_strDBPath);

                fileToOpen = saveFileDialog1.FileName.ToString();


                this.InitializeDBHelper();

                contextMenuStrip1.Items["editThisEntryToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["deleteThisEntryToolStripMenuItem"].Enabled = true;

                addNewEntryToolStripMenuItem_Click(sender, e);
            }

        }

        private void openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Blood Pressure Monitor Files (*.bpmdb)|*.bpmdb";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileToOpen = openFileDialog1.FileName.ToString();

                FileInfo fi = new FileInfo(fileToOpen);

                if (!(fi.Exists))
                {
                    MessageBox.Show("Unable to Open File", "Blood Pressure Monitor Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                //Stream fileStream = fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

                toolStripStatusLabel1.Text = "Current Blood Pressure Monitor File: " + openFileDialog1.FileName + " (Existing)";


                //dataLayer.m_strDBPath = Path.GetDirectoryName(fileToOpen);
                dataLayer.m_strDBPath = fileToOpen;
                dirHelper.SetDBDirPath(Path.GetDirectoryName(fileToOpen));



                this.InitializeDBHelper();
                dataLayer.ListOutRecords_WithCustomFile(ref listView1, monthCalendar1.SelectionStart, fileToOpen);

                contextMenuStrip1.Items["editThisEntryToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["deleteThisEntryToolStripMenuItem"].Enabled = true;
            }
        }

        private bool InitializeDBHelper()
        {
            this.dirHelper = new DirSettingsHelper();
            this.dataLayer = new DBHelper();
            string dBDirPath = this.dirHelper.GetDBDirPath();

            dataLayer.fileToOpen = this.fileToOpen;

            try
            {
                this.dataLayer.InitializeHelper(dataLayer.fileToOpen);
                this.Text = this.Text + " - Current File: " + Path.GetFileName(dataLayer.fileToOpen);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        private void NewRecord()
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!", "No Active BP Monitor File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                FormEdit edit = new FormEdit();
                if (DialogResult.OK == edit.ShowDialog())
                {
                    try
                    {
                        this.dataLayer.InsertRecord(edit.m_DataItem);
                        this.RefreshList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        private void ModifyRecord()
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!", "No Active BP Monitor File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (this.listView1.SelectedIndices.Count > 0)
            {
                int num = this.listView1.SelectedIndices[0];
                ListViewItem item = this.listView1.Items[num];
                if ((item != null) && (item.Tag != null))
                {
                    FormEdit edit = new FormEdit();
                    edit.m_DataItem = (TagDataItem)item.Tag;
                    if (DialogResult.OK == edit.ShowDialog())
                    {
                        this.dataLayer.UpdateRecord(edit.m_DataItem);
                        this.RefreshList();
                    }
                }
            }
        }

        private void DeleteRecord()
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!", "No Active BP Monitor File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            if (this.listView1.SelectedIndices.Count > 0)
            {
                int num = this.listView1.SelectedIndices[0];
                ListViewItem item = this.listView1.Items[num];
                if ((item != null) && (item.Tag != null))
                {
                    TagDataItem tag = (TagDataItem)item.Tag;
                    if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete the selected record?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        this.dataLayer.DeleteRecord(tag.ID);
                        this.RefreshList();
                    }
                }
            }
        }

        private void RefreshList()
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!", "No Active BP Monitor File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.dataLayer.ListOutRecords(ref this.listView1, this.monthCalendar1.SelectionStart);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                if (MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!" + Environment.NewLine + "Would you like to open an existing file?", "No Active BP Monitor File", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click(sender, e);
                    NewRecord();
                }
            }
            else
            {
                this.NewRecord();
            }
        }

        private void editThisEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ModifyRecord();
        }

        private void deleteThisEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeleteRecord();
        }

        private void createNewBPMonitorFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newBloodPressureMonitorDatabaseToolStripMenuItem_Click(sender, e);
        }

        private void openExistingBPMonitorFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click(sender, e);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// export to pdf menu item clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.dataLayer.m_strDBPath == null)
            {
                if (MessageBox.Show("You must open or create a new Blood Pressure Monitoring File before you can do this!" + Environment.NewLine + "Would you like to open an existing file?", "No Active BP Monitor File", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    openExistingBloodPressureMonitorDatabaseToolStripMenuItem_Click(sender, e);
                }
            }

            saveFileDialog1.Title = "Save Data as a PDF Report";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Adobe Acrobat PDF Files (*.pdf)|*.pdf";

            string filenameForPDF = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenameForPDF = saveFileDialog1.FileName;
            }
            
            dataLayer.SaveAsPDF(monthCalendar1.SelectionStart, filenameForPDF);

            MessageBox.Show("PDF File " + filenameForPDF + " has been generated." + Environment.NewLine + "If you have Adobe Acrobat installed the file will open automatically once you click OK.", "Blood Pressure Monitor PDF Engine", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Process.Start(filenameForPDF);
        }
    }
}
