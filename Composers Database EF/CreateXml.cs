using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using ComposersLibrary_EF;

namespace Composers_Database_EF
{
    static class CreateXml
    {
        static public void Create(IQueryable<SONG> table, string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement element;

            int child_counter;
            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null));
            element = xmlDocument.CreateElement("DatabaseTable");
            xmlDocument.AppendChild(element);
            if (table==null) { }
            for (child_counter = 0; child_counter < table.ToList().Count; child_counter++)
            {
                XmlElement song;
                XmlAttribute name;
                XmlAttribute genre;
                XmlAttribute duration;
                song = xmlDocument.CreateElement("Song");
                name = xmlDocument.CreateAttribute("Name");
                name.Value = table.ToList()[child_counter].SNG_NAME;
                genre = xmlDocument.CreateAttribute("Delete");
                genre.Value = table.ToList()[child_counter].SNG_GENRE;
                duration = xmlDocument.CreateAttribute("Duration");
                duration.Value = table.ToList()[child_counter].SNG_DURATION.Value.ToString();
                song.Attributes.Append(name);
                song.Attributes.Append(genre);
                song.Attributes.Append(duration);

                element.AppendChild(song);
            }

            //path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Temporary XML file");
            //Song_Search songs = new Song_Search();
            xmlDocument.Save(path);
            return;
        }
        
    }
}
