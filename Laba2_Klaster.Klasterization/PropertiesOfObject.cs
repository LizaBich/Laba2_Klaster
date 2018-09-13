using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Klaster.Klasterization
{
    public class PropertiesOfObject
    {
        public PropertiesOfObject(double squere, double perimeter, double compactness)
        {
            var delimeter = squere + perimeter + compactness;
            this.NormalizedSquere = squere / delimeter;
            this.NormalizedPerimeter = perimeter / delimeter;
            this.NormalizedCompactness = compactness / delimeter;
        }

        public double NormalizedSquere { get; private set; }

        public double NormalizedPerimeter { get; private set; }

        public double NormalizedCompactness { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is PropertiesOfObject && this.Equals(obj as PropertiesOfObject);
        }

        public bool Equals(PropertiesOfObject obj)
        {
            return this.NormalizedCompactness == obj.NormalizedCompactness &&
                this.NormalizedPerimeter == obj.NormalizedPerimeter &&
                this.NormalizedSquere == obj.NormalizedSquere;
        }
    }
}
