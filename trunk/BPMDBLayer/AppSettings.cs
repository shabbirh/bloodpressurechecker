using System;
using System.Xml.Serialization;


namespace Hassanally.Net.XMLDataLayer
{
    [XmlRoot("AppSettings")]
    public class AppSettings
    {
        public string DBDirectoryPath;
    }
}

