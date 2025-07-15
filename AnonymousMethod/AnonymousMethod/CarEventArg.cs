using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public class CarEventArg : EventArgs
    {
        public readonly string message;
        public CarEventArg(string message) => this.message = message;
    }
}
