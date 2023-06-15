using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5ADD
{
    public class BigPhotoBook
    {
        private int numPages;

        public int NumPages { get { return this.numPages; } set { this.numPages = value; } }
        public int GetNumberPages()
        {

            return NumPages;
        }

        public BigPhotoBook()
        {
            this.numPages = 64;
        }

        public BigPhotoBook(int pages) : this()
        {
            this.numPages = pages;
        }
    }
}
