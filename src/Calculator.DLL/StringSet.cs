using System;
using System.Collections.Generic;

namespace Calculator.DLL
{
    public class StringSet
    {
        public StringSet(int numberOfStrings, string[] prefixes, string[] diameters, double scale, MusicalNote[] notes)
        {
            StringCollection = new List<GuitarString>();

            for (int idx = 0; idx < numberOfStrings; idx++)
            {
                var tmpString = new GuitarString(prefixes[idx], diameters[idx], scale, notes[idx], new StringMaterial(MaterialType.STAINLESS_STEEL));
                StringCollection.Add(tmpString);
            }
        }
        public StringSet()
        {

        }

        public IList<GuitarString> StringCollection { get; set; }
    }
}
