using Calculator.DLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GSTC.Tests
{
    public class StringSetTest
    {
        [Fact]
        public void StringSet()
        {
            string[] prefixes = new string[6] { "PL", "PL", "PL", "NW", "NW", "NW" };
            string[] diameters = new string[6] { "010", "0135", "017", "026", "036", "048" };
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
            Assert.Equal(16.2, Math.Round(tmpStringSet_255.StringCollection[0].StringTension_UW_LB, 1));
            Assert.Equal(16.6, Math.Round(tmpStringSet_255.StringCollection[1].StringTension_UW_LB, 1));
            Assert.Equal(16.6, Math.Round(tmpStringSet_255.StringCollection[2].StringTension_UW_LB, 1));
            Assert.Equal(18.4, Math.Round(tmpStringSet_255.StringCollection[3].StringTension_UW_LB, 1));
            Assert.Equal(19.5, Math.Round(tmpStringSet_255.StringCollection[4].StringTension_UW_LB, 1));
            Assert.Equal(18.9, Math.Round(tmpStringSet_255.StringCollection[5].StringTension_UW_LB, 1));

            //
            Assert.Equal(15.3, Math.Round(tmpStringSet_2475.StringCollection[0].StringTension_UW_LB, 1));
            Assert.Equal(15.6, Math.Round(tmpStringSet_2475.StringCollection[1].StringTension_UW_LB, 1));
            Assert.Equal(15.6, Math.Round(tmpStringSet_2475.StringCollection[2].StringTension_UW_LB, 1));
            Assert.Equal(17.3, Math.Round(tmpStringSet_2475.StringCollection[3].StringTension_UW_LB, 1));
            Assert.Equal(17.9, Math.Round(tmpStringSet_2475.StringCollection[4].StringTension_UW_LB, 1));
            Assert.Equal(17.2, Math.Round(tmpStringSet_2475.StringCollection[5].StringTension_UW_LB, 1));
        }
    }
}
