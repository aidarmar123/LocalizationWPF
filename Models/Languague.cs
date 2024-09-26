using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localization.Models
{
    public partial class Languague
    {
        public Languague(string name, string value, string img)
        {
            Name = name;
            Value = value;
            Img = img;
        }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
