using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace secure.CheckPrinting.com.Models
{
    public class Check
    {
       public List<CheckElements> CheckElementsList { get; set; }
    }

    public class CheckElements
    {
        public string Name { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

}