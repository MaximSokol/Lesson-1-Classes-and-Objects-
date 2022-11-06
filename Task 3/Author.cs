using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_3
{
    class Author
    {
        string author;
        //----------------------

        public Author (string author)
        {
            this.author = author;
        }
        //----------------------------------

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Author" + author);
        }
        //--------------------------------------------------
    }
}
