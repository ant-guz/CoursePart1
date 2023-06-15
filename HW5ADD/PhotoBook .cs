using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5ADD
{
    public class PhotoBook
    {
        private int numPages;

        public int NumPages { get { return this.numPages; } set { this.numPages = value; } }
        public int GetNumberPages() {

            return NumPages;
        }

        public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int pages) : this()
        {
            this.numPages = pages;
        }

    }
}
