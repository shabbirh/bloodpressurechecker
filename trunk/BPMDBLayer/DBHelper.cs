using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Resources;
using System.Collections;
using System.Drawing;

namespace Hassanally.Net.XMLDataLayer
{
    public class DBHelper
    {
        private DataSet m_DataSet;
        public string m_strDBPath;
        public string fileToOpen;

        public void CreateDB()
        {
            if (!this.DBFileExists(this.m_strDBPath))
            {
                DataSet set = new DataSet("xml_dataset_name");
                set.Namespace = "xml_namespace";
                DataTable table = new DataTable("BPRecord");
                DataColumn column = new DataColumn("ID", System.Type.GetType("System.Int64"));
                table.Columns.Add(column);
                column = new DataColumn("Date", System.Type.GetType("System.DateTime"));
                table.Columns.Add(column);
                column = new DataColumn("Systolic", System.Type.GetType("System.Int32"));
                table.Columns.Add(column);
                column = new DataColumn("Diastolic", System.Type.GetType("System.Int32"));
                table.Columns.Add(column);
                column = new DataColumn("HeartRate", System.Type.GetType("System.Int32"));
                table.Columns.Add(column);
                column = new DataColumn("Event", System.Type.GetType("System.Int32"));
                table.Columns.Add(column);
                column = new DataColumn("Description", System.Type.GetType("System.String"));
                table.Columns.Add(column);
                set.Tables.Add(table);
                string strDBPath = this.m_strDBPath;
                set.WriteXml(strDBPath, XmlWriteMode.WriteSchema);
                set.Dispose();
            }
        }

        private bool DBFileExists(string strFilePath)
        {
            FileInfo info = new FileInfo(strFilePath);
            return info.Exists;
        }

        public void DeleteRecord(long ID)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                DataTable table = this.m_DataSet.Tables["BPRecord"];
                string filterExpression = "ID = '" + ID.ToString() + "'";
                DataRow[] rowArray = table.Select(filterExpression);
                if (rowArray.Length > 0)
                {
                    rowArray[0].Delete();
                    if (!table.HasErrors)
                    {
                        table.AcceptChanges();
                    }
                    this.m_DataSet.WriteXml(this.m_strDBPath, XmlWriteMode.WriteSchema);
                }
            }
        }

        public TagDataItem GetRecord(long ID)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                DataTable table = this.m_DataSet.Tables["BPRecord"];
                string filterExpression = "ID = '" + ID.ToString() + "'";
                DataRow[] rowArray = table.Select(filterExpression);
                if (rowArray.Length > 0)
                {
                    return this.GetRecordDetailsIntern(rowArray[0]);
                }
            }
            return null;
        }

        private TagDataItem GetRecordDetailsIntern(DataRow dtRow)
        {
            TagDataItem item = new TagDataItem();
            try
            {
                item.ID = Convert.ToInt64(dtRow["ID"]);
                item.Date = Convert.ToDateTime(dtRow["Date"]);
                item.Systolic = Convert.ToInt32(dtRow["Systolic"]);
                item.Diastolic = Convert.ToInt32(dtRow["Diastolic"]);
                item.HeartRate = Convert.ToInt32(dtRow["HeartRate"]);
                item.Event = Convert.ToInt32(dtRow["Event"]);
                item.Description = Convert.ToString(dtRow["Description"]);
                return item;
            }
            catch
            {
                return null;
            }
        }

        public void InitializeHelper(string strDirPath)
        {
            this.m_DataSet = new DataSet();
            string path = strDirPath;
            this.m_strDBPath = this.fileToOpen;
            this.CreateDB();
            this.LoadRecords();
        }

        public void InsertRecord(TagDataItem dbData)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                dbData.ID = DateTime.Now.Ticks;
                this.UpdateRecordIntern(dbData);
            }
        }

        public void ListOutRecords(ref ListView listView, DateTime dateFilter)
        {
            listView.Items.Clear();
            if (this.DBFileExists(this.m_strDBPath))
            {
                DataTable table = this.m_DataSet.Tables["BPRecord"];
                string str = new DateTime(dateFilter.Year, 1, 1).ToString();
                int year = dateFilter.Year + 1;
                string str2 = new DateTime(year, 1, 1).ToString();
                string filterExpression = "Date > '" + str + "' AND Date <'" + str2 + "'";
                string sort = "Date ASC";
                foreach (DataRow row in table.Select(filterExpression, sort))
                {
                    TagDataItem recordDetailsIntern = this.GetRecordDetailsIntern(row);
                    string text = recordDetailsIntern.Date.ToString("MMM dd, yyyy hh:mm tt");
                    string str6 = recordDetailsIntern.Systolic.ToString() + " / " + recordDetailsIntern.Diastolic.ToString() + " mm Hg";
                    string str7 = recordDetailsIntern.HeartRate.ToString() + " bpm";
                    ListViewItem item2 = new ListViewItem(text);
                    item2.SubItems.Add(str6);
                    item2.SubItems.Add(str7);
                    listView.Items.Add(item2);
                    item2.Tag = recordDetailsIntern;
                    item2.Group = listView.Groups[recordDetailsIntern.Date.Month - 1];
                }
            }
        }

        public void LoadRecords()
        {
            if (!this.DBFileExists(this.m_strDBPath))
            {
                this.CreateDB();
            }
            try
            {
                this.m_DataSet.ReadXml(this.m_strDBPath, XmlReadMode.ReadSchema);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void UpdateRecord(TagDataItem dbData)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                this.UpdateRecordIntern(dbData);
            }
        }

        private void UpdateRecordDetailsIntern(ref DataRow dataRow, TagDataItem dbData)
        {
            dataRow["Date"] = dbData.Date;
            dataRow["Systolic"] = dbData.Systolic;
            dataRow["Diastolic"] = dbData.Diastolic;
            dataRow["HeartRate"] = dbData.HeartRate;
            dataRow["Event"] = dbData.Event;
            dataRow["Description"] = dbData.Description;
        }

        private void UpdateRecordIntern(TagDataItem dbData)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                try
                {
                    DataTable table = this.m_DataSet.Tables["BPRecord"];
                    string filterExpression = "ID = '" + dbData.ID.ToString() + "'";
                    DataRow[] rowArray = table.Select(filterExpression);
                    if (rowArray.Length > 0)
                    {
                        this.UpdateRecordDetailsIntern(ref rowArray[0], dbData);
                    }
                    else
                    {
                        DataRow dataRow = table.NewRow();
                        dataRow["ID"] = dbData.ID;
                        this.UpdateRecordDetailsIntern(ref dataRow, dbData);
                        table.Rows.Add(dataRow);
                    }
                    if (!table.HasErrors)
                    {
                        table.AcceptChanges();
                    }
                    this.m_DataSet.WriteXml(this.m_strDBPath, XmlWriteMode.WriteSchema);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ListOutRecords_WithCustomFile(ref ListView listView1, DateTime dateTime, string fileName)
        {
            this.m_strDBPath = fileName;
            ListOutRecords(ref listView1, dateTime);
        }

        public void SaveAsPDF(DateTime dateFilter, string filenameForPDF)
        {
            if (this.DBFileExists(this.m_strDBPath))
            {
                // lets create the temp PDF file first
                Document document = new Document();
                //PdfWriter.getInstance(document, new FileStream("Chap0101.pdf", FileMode.Create));
                PdfWriter.GetInstance(document, new FileStream(filenameForPDF,FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite));

                HeaderFooter footer = new HeaderFooter(new Phrase("Blood Pressure Monitor Report - Page "), true);
                footer.Border = iTextSharp.text.Rectangle.NO_BORDER;
                document.Footer = footer;

                document.Open();
                System.Drawing.Image bitmapofHeader = BPMDBLayer.Resource1.bpm_report_header;

                iTextSharp.text.Font defaultFont = FontFactory.GetFont(FontFactory.HELVETICA, 8);

                iTextSharp.text.Image bmpHeader = iTextSharp.text.Image.GetInstance(bitmapofHeader, System.Drawing.Imaging.ImageFormat.Png);
                bmpHeader.Alignment = iTextSharp.text.Image.MIDDLE_ALIGN;

                document.Add(bmpHeader);

                Paragraph TitleLine = new Paragraph("Blood Pressure Monitor PDF Report" + Environment.NewLine + "Generated on " + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToShortTimeString() + Environment.NewLine + Environment.NewLine, FontFactory.GetFont(FontFactory.HELVETICA_BOLD,12));
                TitleLine.SetAlignment("center");


                document.Add(TitleLine);

                Table table = new Table(3);
                table.BorderWidth = 1;
                table.BorderColor = iTextSharp.text.Color.BLACK;
                table.Cellpadding = 1;
                table.Cellspacing = 1;

                Cell cell = new Cell("Date of Reading");
                cell.Header = true;
                cell.BackgroundColor = iTextSharp.text.Color.PINK;
                cell.NoWrap = false;
                cell.Colspan = 1;
                table.AddCell(cell);

                cell = new Cell("Systolic/Diastolic (mmHg)");
                cell.Header = true;
                cell.BackgroundColor = iTextSharp.text.Color.PINK;
                cell.Colspan = 1;
                cell.NoWrap = false;
                table.AddCell(cell);

                cell = new Cell("Heart Rate (bpm)");
                cell.Header = true;
                cell.BackgroundColor = iTextSharp.text.Color.PINK;
                cell.Colspan = 1;
                cell.NoWrap = false;
                table.AddCell(cell);

                DataTable dtable = this.m_DataSet.Tables["BPRecord"];
                string str = new DateTime(dateFilter.Year, 1, 1).ToString();
                int year = dateFilter.Year + 1;
                string str2 = new DateTime(year, 1, 1).ToString();
                string filterExpression = "Date > '" + str + "' AND Date <'" + str2 + "'";
                string sort = "Date ASC";
                foreach (DataRow row in dtable.Select(filterExpression, sort))
                {
                    TagDataItem recordDetailsIntern = this.GetRecordDetailsIntern(row);
                    string text = recordDetailsIntern.Date.ToLongDateString() + " at " + recordDetailsIntern.Date.ToShortTimeString();
                    string str6 = recordDetailsIntern.Systolic.ToString() + " / " + recordDetailsIntern.Diastolic.ToString() + " mm Hg";
                    string str7 = recordDetailsIntern.HeartRate.ToString() + " bpm";
                    
                    cell = new Cell(text);
                    cell.Header = false;
                    cell.BackgroundColor = iTextSharp.text.Color.WHITE;
                    cell.Colspan = 1;
                    table.AddCell(cell);

                    cell = new Cell(str6);
                    cell.Header = false;
                    cell.BackgroundColor = iTextSharp.text.Color.WHITE;
                    cell.Colspan = 1;
                    table.AddCell(cell);

                    cell = new Cell(str7);
                    cell.Header = false;
                    cell.BackgroundColor = iTextSharp.text.Color.WHITE;
                    cell.Colspan = 1;
                    table.AddCell(cell);
                }
                document.Add(table);
                document.Close();
            }
        }
    }
}

