using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadXML();
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

        public static void ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Bib));
            var file = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SerializationOverview.xml");

            Bib Bib = (Bib)reader.Deserialize(file);

            foreach (Book book in Bib.BookList)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.TotalAmountOfPages);
            }
            Console.ReadKey();
        }
    }
}
