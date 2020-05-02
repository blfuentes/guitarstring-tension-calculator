using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.DLL
{
    public class UnitWeight
    {
        public UnitWeight(string prefix, string diameter, double value)
        {
            this.MaterialPrefix = prefix;
            this.StringDiameter = diameter;
            this.Value = value;
        }

        public string MaterialPrefix { get; set; }
        public string StringDiameter { get; set; }
        public double Value { get; set; }
        public string FullName => $"{MaterialPrefix}{StringDiameter}";
    }
    public static class UnitWeightRepo
    {

        public static UnitWeight GetUnitWeight(string prefix, string diameter)
        {
            var tmpByDiameter = Repository.Where(_s => _s.StringDiameter.Equals(diameter));
            var tmpByPrefix = tmpByDiameter.FirstOrDefault(_s => _s.MaterialPrefix.Equals(prefix));
            if (tmpByPrefix == null)
                tmpByPrefix = tmpByDiameter.First();

            return tmpByPrefix;
        }

        private static List<UnitWeight> Repository = new List<UnitWeight>()
        {
            //Plain Steel - Lock Twist
            new UnitWeight("PL", "007", 0.00001085),
            new UnitWeight("PL", "008", 0.00001418),
            new UnitWeight("PL", "0085", 0.00001601),
            new UnitWeight("PL", "009", 0.00001794),
            new UnitWeight("PL", "0095", 0.00001999),
            new UnitWeight("PL", "010", 0.00002215),
            new UnitWeight("PL", "0105", 0.00002442),
            new UnitWeight("PL", "011", 0.00002680),
            new UnitWeight("PL", "0115", 0.00002930),
            new UnitWeight("PL", "012", 0.00003190),
            new UnitWeight("PL", "013", 0.00003744),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", "0135", 0.00004037),
            new UnitWeight("PL", "014", 0.00004342),
            new UnitWeight("PL", "015", 0.00004984),
            new UnitWeight("PL", "016", 0.00005671),
            new UnitWeight("PL", "017", 0.00006402),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", "018", 0.00007177),
            new UnitWeight("PL", "019", 0.00007997),
            new UnitWeight("PL", "020", 0.00008861),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", "022", 0.00010722),
            new UnitWeight("PL", "024", 0.00012760),
            new UnitWeight("PL", "026", 0.00014975),
            //Plain Steel - Soldered Twist
            new UnitWeight("KPL", "009", 0.00014975),
            new UnitWeight("KPL", "010", 0.00014975),
            new UnitWeight("KPL", "011", 0.00014975),
            new UnitWeight("KPL", "012", 0.00014975),
            new UnitWeight("KPL", "013", 0.00014975),
            //Plain Steel - Soldered Twist
            new UnitWeight("KPL", "014", 0.00004342),
            new UnitWeight("KPL", "016", 0.00005671),
            new UnitWeight("KPL", "017", 0.00006402),
            new UnitWeight("KPL", "020", 0.00008861),
            //Plain Steel - Double Ball End
            new UnitWeight("SPL", "009", 0.00001794),
            new UnitWeight("SPL", "010", 0.00002215),
            new UnitWeight("SPL", "011", 0.00002680),
            new UnitWeight("SPL", "013", 0.00003744),
            //Plain Steel - Double Ball End
            new UnitWeight("SPL", "016", 0.00005671),
            new UnitWeight("SPL", "017", 0.00006402),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", "017", 0.00005524),
            new UnitWeight("NW", "018", 0.00006215),
            new UnitWeight("NW", "019", 0.00006947),
            new UnitWeight("NW", "020", 0.00007495),
            new UnitWeight("NW", "021", 0.00008293),
            new UnitWeight("NW", "022", 0.00009184),
            new UnitWeight("NW", "024", 0.00010857),
            new UnitWeight("NW", "026", 0.00012671),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", "028", 0.00014666),
            new UnitWeight("NW", "030", 0.00017236),
            new UnitWeight("NW", "032", 0.00019347),
            new UnitWeight("NW", "034", 0.00021590),
            new UnitWeight("NW", "036", 0.00023964),
            new UnitWeight("NW", "038", 0.00026471),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", "039", 0.00027932),
            new UnitWeight("NW", "042", 0.00032279),
            new UnitWeight("NW", "044", 0.00035182),
            new UnitWeight("NW", "046", 0.00038216),
            new UnitWeight("NW", "048", 0.00041382),
            new UnitWeight("NW", "049", 0.00043014),
            new UnitWeight("NW", "052", 0.00048109),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", "054", 0.00053838),
            new UnitWeight("NW", "056", 0.00057598),
            new UnitWeight("NW", "059", 0.00064191),
            new UnitWeight("NW", "060", 0.00066542),
            new UnitWeight("NW", "062", 0.00070697),
            new UnitWeight("NW", "064", 0.00074984),
            new UnitWeight("NW", "066", 0.00079889),
            new UnitWeight("NW", "068", 0.00084614),
            new UnitWeight("NW", "070", 0.00089304),
            new UnitWeight("NW", "072", 0.00094124),
            new UnitWeight("NW", "074", 0.00098869),
            new UnitWeight("NW", "080", 0.00115011),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", "024", 0.00010857),
            new UnitWeight("NW", "026", 0.00012671),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", "032", 0.00019347),
            new UnitWeight("NW", "036", 0.00023964),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", "042", 0.00032279),
            new UnitWeight("NW", "046", 0.00038216),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", "018", 0.00006588),
            new UnitWeight("XSG", "020", 0.00007919),
            new UnitWeight("XSG", "021", 0.00008774),
            new UnitWeight("XSG", "022", 0.00009731),
            new UnitWeight("XSG", "024", 0.00011501),
            new UnitWeight("XSG", "026", 0.00013419),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", "028", 0.00015493),
            new UnitWeight("XSG", "030", 0.00018203),
            new UnitWeight("XSG", "032", 0.00020398),
            new UnitWeight("XSG", "034", 0.00022729),
            new UnitWeight("XSG", "036", 0.00025198),
            new UnitWeight("XSG", "038", 0.00027804),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", "040", 0.00031044),
            new UnitWeight("XSG", "042", 0.00033924),
            new UnitWeight("XSG", "046", 0.00040096),
            new UnitWeight("XSG", "048", 0.00043387),
            new UnitWeight("XSG", "050", 0.00046816),
            new UnitWeight("XSG", "052", 0.00050382),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", "054", 0.00056388),
            new UnitWeight("XSG", "056", 0.00060297),
            new UnitWeight("XSG", "070", 0.00092592),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", "022", 0.00011271),
            new UnitWeight("HRG", "024", 0.00012857),
            new UnitWeight("HRG", "026", 0.00014750),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", "030", 0.00018970),
            new UnitWeight("HRG", "032", 0.00021100),
            new UnitWeight("HRG", "036", 0.00025650),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", "039", 0.00029700),
            new UnitWeight("HRG", "042", 0.00033400),
            new UnitWeight("HRG", "046", 0.00039810),
            new UnitWeight("HRG", "052", 0.00049500),
            new UnitWeight("HRG", "056", 0.00056700),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", "020", 0.00007812),
            new UnitWeight("CG", "022", 0.00009784),
            new UnitWeight("CG", "024", 0.00011601),
            new UnitWeight("CG", "026", 0.00013574),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", "028", 0.00014683),
            new UnitWeight("CG", "030", 0.00016958),
            new UnitWeight("CG", "032", 0.00019233),
            new UnitWeight("CG", "035", 0.00024197),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", "038", 0.00026520),
            new UnitWeight("CG", "040", 0.00031676),
            new UnitWeight("CG", "042", 0.00034377),
            new UnitWeight("CG", "045", 0.00040393),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", "048", 0.00043541),
            new UnitWeight("CG", "050", 0.00047042),
            new UnitWeight("CG", "052", 0.00049667),
            new UnitWeight("CG", "056", 0.00059075),
            new UnitWeight("CG", "065", 0.00089364)
        };
    }
}
