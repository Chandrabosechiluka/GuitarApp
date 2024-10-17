using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    public class GuitarSpec
    {
        public string Builder { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string BackWood { get; private set; }
        public string TopWood { get; private set; }
        public int NumStrings { get; private set; }

        public GuitarSpec(string builder, string model, string type, string backWood, string topWood, int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }

        public int GetNumStrings()
        {
            return NumStrings;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder) return false;
            if (Model != null && !Model.Equals(otherSpec.Model)) return false;
            if (Type != null && !Type.Equals(otherSpec.Type)) return false;
            if (BackWood != null && !BackWood.Equals(otherSpec.BackWood)) return false;
            if (TopWood != null && !TopWood.Equals(otherSpec.TopWood)) return false;
            if (NumStrings != otherSpec.NumStrings) return false;
            return true;
        }
    }

}
