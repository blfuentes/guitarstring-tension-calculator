using Calculator.DLL;
using System;
using Xunit;

namespace GSTC.bUnit
{
    public class StringSetTest
    {
        [Fact]
        public void StringSet()
        {
            string[] prefixes = new string[6] { "PL", "PL", "PL", "NW", "NW", "NW" };
            double[] diameters = new double[6] { 0.010, 0.013, 0.017, 0.026, 0.036, 0.048 };
            MusicalNote[] notes = new MusicalNote[6]
            {
                new MusicalNote("E", 4),
                new MusicalNote("B", 3),
                new MusicalNote("G", 3),
                new MusicalNote("D", 3),
                new MusicalNote("A", 2),
                new MusicalNote("E", 2),
            };
            var tmpStringSet_255 = new StringSet(6, prefixes, diameters, 25.5, notes);
            var tmpStringSet_2475 = new StringSet(6, prefixes, diameters, 24.75, notes);

            //
            Assert.Equal(Math.Round(16.2, 1), Math.Round(tmpStringSet_255.StringCollection[0].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(15.4, 1), Math.Round(tmpStringSet_255.StringCollection[1].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(16.6, 1), Math.Round(tmpStringSet_255.StringCollection[2].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(18.4, 1), Math.Round(tmpStringSet_255.StringCollection[3].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(19.5, 1), Math.Round(tmpStringSet_255.StringCollection[4].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(18.9, 1), Math.Round(tmpStringSet_255.StringCollection[5].StringTension_UW_LB, 1));

            //
            Assert.Equal(Math.Round(15.3, 1), Math.Round(tmpStringSet_2475.StringCollection[0].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(14.5, 1), Math.Round(tmpStringSet_2475.StringCollection[1].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(15.6, 1), Math.Round(tmpStringSet_2475.StringCollection[2].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(17.3, 1), Math.Round(tmpStringSet_2475.StringCollection[3].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(18.4, 1), Math.Round(tmpStringSet_2475.StringCollection[4].StringTension_UW_LB, 1));
            Assert.Equal(Math.Round(17.8, 1), Math.Round(tmpStringSet_2475.StringCollection[5].StringTension_UW_LB, 1));
        }
    }
}
