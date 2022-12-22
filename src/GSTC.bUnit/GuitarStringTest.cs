using Calculator.DLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GSTC.bUnit
{
    public class GuitarStringTest
    {
        [Fact]
        public void GuitarString()
        {
            //d = 1 / L * √T * 1 / F * 1 /√ (π * ρ)
            //double d = (1.0 / 0.59) * Math.Sqrt(35) * (1.0 / tmp_gut.Note.Frequency) * (1.0 / Math.Sqrt(Math.PI * tmp_gut.Material.Density));
            //double t = Math.Pow(d * 0.59 * tmp_gut.Note.Frequency * Math.Sqrt(Math.PI * tmp_gut.Material.Density), 2);

            GuitarString tmp_ssteel_e4 = new GuitarString(1, "PL", 0.010, 25.5, (new FreqRepo()).GetMusicalNote("E", 4), new StringMaterial(MaterialType.STAINLESS_STEEL));
            GuitarString tmp_ssteel_b3 = new GuitarString(2, "PL", 0.014, 25.5, (new FreqRepo()).GetMusicalNote("B", 3), new StringMaterial(MaterialType.STAINLESS_STEEL));
            GuitarString tmp_ssteel_g3 = new GuitarString(3, "PL", 0.022, 25.5, (new FreqRepo()).GetMusicalNote("G", 3), new StringMaterial(MaterialType.STAINLESS_STEEL));
            GuitarString tmp_ssteel_d3 = new GuitarString(4,"NW", 0.030, 25.5, (new FreqRepo()).GetMusicalNote("D", 3), new StringMaterial(MaterialType.STAINLESS_STEEL));
            GuitarString tmp_ssteel_a2 = new GuitarString(5, "NW", 0.039, 25.5, (new FreqRepo()).GetMusicalNote("A", 2), new StringMaterial(MaterialType.STAINLESS_STEEL));
            GuitarString tmp_ssteel_e2 = new GuitarString(6, "NW", 0.046, 25.5, (new FreqRepo()).GetMusicalNote("E", 2), new StringMaterial(MaterialType.STAINLESS_STEEL));

            Assert.Equal(16.2, Math.Round(tmp_ssteel_e4.StringTension_UW_LB, 1));
            Assert.Equal(17.8, Math.Round(tmp_ssteel_b3.StringTension_UW_LB, 1));
            Assert.Equal(27.7, Math.Round(tmp_ssteel_g3.StringTension_UW_LB, 1));
            Assert.Equal(25.0, Math.Round(tmp_ssteel_d3.StringTension_UW_LB, 1));
            Assert.Equal(22.8, Math.Round(tmp_ssteel_a2.StringTension_UW_LB, 1));
            Assert.Equal(17.5, Math.Round(tmp_ssteel_e2.StringTension_UW_LB, 1));
        }
    }
}
