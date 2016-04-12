using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializerProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bib Bib = new Bib();
            Bib.BookList.Add(new Book("De Grijze Jager", 200));
            Bib.BookList.Add(new Book("Koepels", 415));
            WriteXML(Bib);
        }
        public class Bib
        {
            public List<Book> BookList = new List<Book>();
            
        }

        public class Book
        {
            public string Title;
            public int TotalAmountOfPages;

            public Book()
            {

            }

            public Book(string _Title, int _TotalAmountOfPages)
            {
                Title = _Title;
                TotalAmountOfPages = _TotalAmountOfPages;
            }
        }

        public static void WriteXML(Bib _Bib)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Bib));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, _Bib);
            file.Close();
            
        }
    }
}
