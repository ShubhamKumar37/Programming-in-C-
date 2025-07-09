using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Fork : IPointy
    {
        public string PropName {  get; set; }
        public byte GetNumberOfPoints() => 132;
        public byte Points => 4;
    }
    class PitchFork : IPointy
    {
        public byte Points => 3;
        public string PropName { get; set; }
        public byte GetNumberOfPoints() => 132;
    } 
    class Knife : IPointy
    {
        public byte Points => 1;
        public string PropName { get; set; }
        public byte GetNumberOfPoints() => 132;
    }
}
