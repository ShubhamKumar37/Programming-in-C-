﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    public class PointyTestClass : IPointy
    {
        public string PropName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public byte Points => throw new NotImplementedException();

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}
