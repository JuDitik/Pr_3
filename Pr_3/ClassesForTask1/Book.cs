using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pr_3.ClassesForTask1
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
