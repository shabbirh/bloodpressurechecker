using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hassanally.Net.XMLDataLayer;

namespace Hassanally.Net.BPMonitor
{
    public partial class FormEdit : Form
    {
        public TagDataItem m_DataItem;

        public FormEdit()
        {
            InitializeComponent();
            this.m_DataItem = new TagDataItem();
            this.button1.DialogResult = DialogResult.OK;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            this.dateTimePicker.Value = this.m_DataItem.Date;
            this.txtSystolic.Text = this.m_DataItem.Systolic.ToString();
            this.txtDiastolic.Text = this.m_DataItem.Diastolic.ToString();
            this.txtHeartRate.Text = this.m_DataItem.HeartRate.ToString();
            this.txtNotes.Text = this.m_DataItem.Description.ToString();
        }

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (base.DialogResult == DialogResult.OK)
            {
                bool flag = this.CheckValues();
                e.Cancel = !flag;
            }
        }

        private bool CheckValues()
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            if (this.txtSystolic.Text.Length > 0)
            {
                try
                {
                    num = Convert.ToInt32(this.txtSystolic.Text);
                }
                catch
                {
                    MessageBox.Show("Enter a valid Systolic value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    this.txtSystolic.Focus();
                    return false;
                }
            }
            if (this.txtDiastolic.Text.Length > 0)
            {
                try
                {
                    num2 = Convert.ToInt32(this.txtDiastolic.Text);
                }
                catch
                {
                    MessageBox.Show("Enter a valid Diastolic value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    this.txtDiastolic.Focus();
                    return false;
                }
            }
            if (this.txtHeartRate.Text.Length > 0)
            {
                try
                {
                    num3 = Convert.ToInt32(this.txtHeartRate.Text);
                }
                catch
                {
                    MessageBox.Show("Enter a valid Heart Rate value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    this.txtHeartRate.Focus();
                    return false;
                }
            }
            if (num <= 0)
            {
                MessageBox.Show("Systolic value cannot be empty or zero.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                this.txtSystolic.Focus();
                return false;
            }
            if (num2 <= 0)
            {
                MessageBox.Show("Diastolic value cannot be empty or zero.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                this.txtDiastolic.Focus();
                return false;
            }
            if (num3 <= 0)
            {
                MessageBox.Show("Heart Rate value cannot be empty or zero.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                this.txtHeartRate.Focus();
                return false;
            }
            this.m_DataItem.Date = this.dateTimePicker.Value;
            this.m_DataItem.Systolic = num;
            this.m_DataItem.Diastolic = num2;
            this.m_DataItem.HeartRate = num3;
            this.m_DataItem.Description = this.txtNotes.Text;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
