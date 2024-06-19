using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumference_LeviAndAneel {
    public abstract class Shape { 
        public string Name { get; set; }
        public abstract double GetArea();
        public abstract double GetCircumference();
    }
}
