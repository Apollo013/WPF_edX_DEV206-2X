using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace ReTemplating.Models
{
    public class Item
    {
        public string Title { get; set; }
        public Color SymbolColor { get; set; }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
