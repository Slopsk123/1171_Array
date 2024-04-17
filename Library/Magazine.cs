using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Magazine
    {
        private string publisher;
        private string name;
        private int month;
        private int pages;

        public string Publisher { get { return publisher; } }
        public string Name { get { return name; } }
        public int Month { get { return month; } }
        public int Pages { get { return pages; } }

        public Magazine(string publisher, string name, int month, int pages)
        {
            this.publisher = publisher;
            this.name = name;
            this.month = month;
            this.pages = pages;
        }
    }
}
