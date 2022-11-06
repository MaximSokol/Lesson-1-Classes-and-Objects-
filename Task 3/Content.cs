using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_3
{
    class Content
    {
        string content;
        //----------------------

        public Content(string content)
        {
            this.content = content;
        }
        //----------------------------------

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Content" + content);
        }
        //--------------------------------------------------
    }
}
