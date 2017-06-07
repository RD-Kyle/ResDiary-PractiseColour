using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TableData
    {
        public List<Colour> colours = new List<Colour>();

        public TableData()
        {
            colours.Add(new Colour { id = 0, name = "Blue" });
            colours.Add(new Colour { id = 1, name = "Red" });
        }
    }
}