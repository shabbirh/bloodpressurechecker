using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Hassanally.Net.XMLDataLayer
{
    public class DirSettingsHelper
    {
        private string m_strFilePath;

        public DirSettingsHelper()
        {
            //string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string directoryName = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            this.m_strFilePath = directoryName + @"\bpmonitor_settings.xml";
        }

        public string GetDBDirPath()
        {
            string dBDirectoryPath = string.Empty;
            if (File.Exists(this.m_strFilePath))
            {
                try
                {
                    AppSettings settings = new AppSettings();
                    StreamReader textReader = new StreamReader(this.m_strFilePath);
                    XmlSerializer serializer = new XmlSerializer(settings.GetType());
                    settings = serializer.Deserialize(textReader) as AppSettings;
                    dBDirectoryPath = settings.DBDirectoryPath;
                    textReader.Close();
                }
                catch
                {
                    dBDirectoryPath = string.Empty;
                }
            }
            return dBDirectoryPath;
        }

        public void SetDBDirPath(string strDirPath)
        {
            if (strDirPath != "")
            {
                try
                {
                    AppSettings o = new AppSettings();
                    o.DBDirectoryPath = strDirPath;
                    StreamWriter writer = new StreamWriter(this.m_strFilePath);
                    new XmlSerializer(o.GetType()).Serialize((TextWriter) writer, o);
                    writer.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        
    }
}

