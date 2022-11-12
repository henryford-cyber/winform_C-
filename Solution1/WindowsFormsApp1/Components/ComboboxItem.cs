using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Components
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public dynamic Value { get; set; }

        public ComboboxItem(string text, dynamic value)
        {
            this.Text = text;
            this.Value = value;
        }

        public ComboboxItem() { }

        public override string ToString()
        {
            return Text;
        }
    }
}
