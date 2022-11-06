using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_3
{
    class Tittle
    {
        string titttle;
        //----------------------

        public Tittle(string titttle) 
        { 
            this.titttle = titttle;
        }
        //----------------------------------

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tittle" + titttle);
        }
        //--------------------------------------------------
    }
}
