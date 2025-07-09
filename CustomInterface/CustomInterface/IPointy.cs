using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    public interface IPointy
    {
        byte GetNumberOfPoints();
        //public IPointy() { } // An interface cannot contain any constructor

        string PropName { get; set; }
        byte Points { get; } // readonly property
    }

    public interface IRegularlyPointy : IPointy
    {
        int SideLength { get; set; }
        int NumberOfSides { get; set; }
        int Perimeter => SideLength * NumberOfSides;
        byte GetNumberOfPoints();

        static string ExampleProperty { get; set;}
        static IRegularlyPointy() => ExampleProperty = "GOOF";
    }

    public interface IDraw3D
    {
        void Draw3D();
    }
}
