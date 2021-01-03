using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDetail
{
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private string edition;

        public Book(int id, string name, string author, string edition)
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.Edition = edition;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Edition { get => edition; set => edition = value; }
    }
}
