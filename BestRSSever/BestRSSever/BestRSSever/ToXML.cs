using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace BestRSSever
{
    public class ToXML
    {
        //public class XMLfile
        //{
        //    public string FileTitle;
        //}

        //public static void ReadRSS(string RSSURL)
        //{
        //    XmlTextReader reader = new XmlTextReader(RSSURL);

        //    //XmlDocument xdoc = new XmlDocument();
        //    //xdoc.Load("http://bash.im/rss/");
        //    //if (xdoc != null)
        //    //{
        //    //    XmlElement root = xdoc.DocumentElement;
        //    //    XmlNodeList xNodelst = root.SelectNodes("job");
        //    //    foreach (XmlNode node in xNodelst)
        //    //    {
        //    //        string location = node.SelectSingleNode("location").InnerText;
        //    //        Response.Write("<br/> location = " + location);
        //    //    }
        //    //}
        //    WebRequest WebReq = WebRequest.Create("http://bash.im/rss/");
        //    WebResponse webRes = WebReq.GetResponse();

        //    Stream rssStream = webRes.GetResponseStream();
        //    XDocument xmlDoc = XDocument.Parse();
        //    xmlDoc.Load(rssStream);

        //    xmlDoc.Save(@"C:\result.xml");

        //    //XmlNodeList xmlNodeList = xmlDoc.SelectNodes("rss/channel/item");

        //    //for (int i = 0; i < xmlNodeList.Count; i++)
        //    //{
        //    //    XmlNode xmlNode;

        //    //    xmlNode = xmlNodeList.Item(i).SelectSingleNode("title");
        //    //    if (xmlNode != null)
        //    //    {
        //    //        RowValues[0] = xmlNode.InnerText;
        //    //    }
        //    //    else
        //    //    {
        //    //        RowValues[0] = "";
        //    //    }

        //    //    xmlNode = xmlNodeList.Item(i).SelectSingleNode("Description");
        //    //    if (xmlNode != null)
        //    //    {
        //    //        RowValues[1] = xmlNode.InnerText;
        //    //    }
        //    //    else
        //    //    {
        //    //        RowValues[1] = "";
        //    //    }

        //    //    xmlNode = xmlNodeList.Item(i).SelectSingleNode("pubDate");
        //    //    if (xmlNode != null)
        //    //    {
        //    //        RowValues[2] = xmlNode.InnerText;
        //    //    }
        //    //    else
        //    //    {
        //    //        RowValues[2] = "";
        //    //    }

        //    //    xmlNode = xmlNodeList.Item(i).SelectSingleNode("link");
        //    //    if (xmlNode != null)
        //    //    {
        //    //        RowValues[3] = xmlNode.InnerText;
        //    //    }
        //    //    else
        //    //    {
        //    //        RowValues[3] = "";
        //    //    }
        //    //}
        //}

        //public static void WriteToXML()
        //{
        //    XMLfile workingXML = new XMLfile();
        //    workingXML.FileTitle = "Serialization Overview";
        //    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(XMLfile));
            
        //    var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//SerializationOverview.xml";
        //    System.IO.FileStream file = System.IO.File.Create(path);
            
        //    writer.Serialize(file, workingXML);
        //    file.Close();


            
        //}
    //    using (XmlWriter writer = XmlWriter.Create("employees.xml"))
    //    {

    //    writer.WriteStartDocument();
    //    writer.WriteStartElement("Employees");

    //    foreach (NewsItem newsitem in employees)
    //    {
    //    writer.WriteStartElement("Employee");

    //    writer.WriteElementString("ID", employee.Id.ToString());
    //    writer.WriteElementString("FirstName", employee.FirstName);
    //    writer.WriteElementString("LastName", employee.LastName);
    //    writer.WriteElementString("Salary", employee.Salary.ToString());

    //    writer.WriteEndElement();
    //    }

    //    writer.WriteEndElement();
    //    writer.WriteEndDocument();
    //}
    }

            //// load rss
            //XmlDocument rssXmlDoc = new XmlDocument();
            //rssXmlDoc.Load("http://bash.im/rss/");
            //// parse rss
            //XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");

            //StringBuilder rssContent = new StringBuilder();

            ////move per items
            //foreach (XmlNode rssNode in rssNodes)
            //{
            //    XmlNode rssSubNode = rssNode.SelectSingleNode("title");
            //    string title = rssSubNode != null ? rssSubNode.InnerText : "";

            //    rssSubNode = rssNode.SelectSingleNode("link");
            //    string link = rssSubNode != null ? rssSubNode.InnerText : "";

            //    rssSubNode = rssNode.SelectSingleNode("description");
            //    string description = rssSubNode != null ? rssSubNode.InnerText : "";

            //    rssContent.Append("<a href='" + link + "'>" + title + "</a><br>" + description);
            //}

            //// Return the string that contain the RSS items
            //return rssContent.ToString();
}
