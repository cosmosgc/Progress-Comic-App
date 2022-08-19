using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Progress_Bar_App.Models
{
    public class Comic
    {
        public int id { get; set; }
        public Image image { get; set; }
        public string name { get; set; }
        public Image Progress { get; set; }
        public int max { get; set; }
        public int value { get; set; }
        //public string imagePath { get; set; }
    }
}
