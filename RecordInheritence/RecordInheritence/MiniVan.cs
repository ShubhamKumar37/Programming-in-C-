using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritence
{
    public sealed record MiniVan : Car
    {
        public int Seating { get; init; }
        public MiniVan(string Make, string Model, string Color, int Seating) : base(Make, Model, Color)
        {
            this.Seating = Seating;
        }
    }
}
