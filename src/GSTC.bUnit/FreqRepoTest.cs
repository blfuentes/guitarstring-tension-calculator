using Calculator.DLL;
using System;
using Xunit;

namespace GSTC.bUnit
{
    public class FreqRepoTest
    {
        [Fact]
        public void GetMusicalNote()
        {
            FreqRepo tmp = new FreqRepo();
            var C1_test = tmp.GetMusicalNote("C", 1);
            var D2_test = tmp.GetMusicalNote("D", 2);
            var E3_test = tmp.GetMusicalNote("E", 3);
            var F4_test = tmp.GetMusicalNote("F", 4);
            var G5_test = tmp.GetMusicalNote("G", 5);
            var A6_test = tmp.GetMusicalNote("A", 6);
            var B7_test = tmp.GetMusicalNote("B", 7);

            Assert.Equal(Math.Round(32.703, 1), Math.Round(C1_test.Frequency, 1));
            Assert.Equal(Math.Round(73.416, 1), Math.Round(D2_test.Frequency, 1));
            Assert.Equal(Math.Round(164.814, 1), Math.Round(E3_test.Frequency, 1));
            Assert.Equal(Math.Round(349.228, 1), Math.Round(F4_test.Frequency, 1));
            Assert.Equal(Math.Round(783.991, 1), Math.Round(G5_test.Frequency, 1));
            Assert.Equal(Math.Round(1760.0, 1), Math.Round(A6_test.Frequency, 1));
            Assert.Equal(Math.Round(3951.066, 1), Math.Round(B7_test.Frequency, 1));
        }
    }
}
