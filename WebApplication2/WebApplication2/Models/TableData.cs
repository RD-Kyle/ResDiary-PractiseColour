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
            colours.Add(new Colour { Id = 0, Name = "Blue" });
            colours.Add(new Colour { Id = 1, Name = "Red" });
        }
    }
}