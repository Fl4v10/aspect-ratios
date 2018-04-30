using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Display
    {
        public int Id { get; set; }
        public Size DisplaySize { get; set; }
        public List<DisplayTypePrice> Prices { get; set; }
    }
}