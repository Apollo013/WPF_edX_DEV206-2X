using ReTemplating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace ReTemplating.ViewModels
{
    public class ItemsViewModel
    {
        public List<Item> Items { get; set; }
        public String Title { get; set; }

        public ItemsViewModel()
        {
            Title = "Data & ListBox Template Binding";
            Items = new List<Item>
            {
                new Item { Title = "Denver", SymbolColor = Colors.Red },
                new Item { Title = "Easy", SymbolColor = Colors.Green },
                new Item { Title = "Frank", SymbolColor = Colors.Blue }
            };
        }
    }
}
