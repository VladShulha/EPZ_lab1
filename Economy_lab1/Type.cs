using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPZ_lab1
{
    public class Type
    {
        public string Name { get; private set; }
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }
        public double d { get; private set; }

        public Type(string Name, double a, double b, double c, double d)
        {
            this.Name = Name;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }
}
