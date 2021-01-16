using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWS
{
    public class Newsarticle
    {
        private int newid;
        private string typename;
        private string title;
        private string content;
        private string author;

        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public string Title { get => title; set => title = value; }
        public string Typename { get => typename; set => typename = value; }
        public int Newid { get => newid; set => newid = value; }
    }
}
