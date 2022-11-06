using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_3
{
    class Book
    {
        Tittle tittle;
        Author author;
        Content content;
        //-----------------------------

        public Book(Tittle tittle, Author author, Content content)
        {
            this.tittle = tittle;
            this.author = author;
            this.content = content;
        }

        public void ShowDate()
        {
            tittle.Show();
            author.Show();
            content.Show();
        }
    }
}
