using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    public interface IPointy
    {
        byte GetNumberOfPoints();
        //public IPointy() { } // An interface cannot contain any constructor

        string PropName { get; set; }
        byte Points { get; } // readonly property
    }
}
