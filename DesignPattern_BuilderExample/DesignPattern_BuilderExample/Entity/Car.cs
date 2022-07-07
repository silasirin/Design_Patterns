﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_BuilderExample
{
    public class Car
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "Brand Name: "+BrandName+"\nModel Name: "+ModelName +"\nColor: "+Color;
        }
    }
}
