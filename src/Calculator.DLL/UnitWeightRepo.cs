using System.Collections.Generic;
using System.Linq;

namespace Calculator.DLL
{
    public class UnitWeight
    {
        public UnitWeight(string prefix, double diameter, double value)
        {
            this.MaterialPrefix = prefix;
            this.StringDiameter = diameter;
            this.Value = value;
        }

        const double _PULGADA_ = 0.0254;

        public string MaterialPrefix { get; set; }
        public double StringDiameter { get; set; }
        public double StringDiameter_INCH => StringDiameter * _PULGADA_;
        public double Value { get; set; }
        public string FullName => $"{MaterialPrefix}{StringDiameter}";
    }
    public static class UnitWeightRepo
    {

        public static UnitWeight GetUnitWeight(string prefix, double diameter)
        {
            var tmpByDiameter = Repository.Where(_s => _s.StringDiameter.Equals(diameter));
            var tmpByPrefix = tmpByDiameter.FirstOrDefault(_s => _s.MaterialPrefix.Equals(prefix));
            if (tmpByPrefix == null)
                tmpByPrefix = tmpByDiameter.First();

            return tmpByPrefix;
        }

        public static List<UnitWeight> Repository = new List<UnitWeight>()
        {
            //Plain Steel - Lock Twist
            new UnitWeight("PL", 0.007, 0.00001085),
            new UnitWeight("PL", 0.008, 0.00001418),
            new UnitWeight("PL", 0.0085, 0.00001601),
            new UnitWeight("PL", 0.009, 0.00001794),
            new UnitWeight("PL", 0.0095, 0.00001999),
            new UnitWeight("PL", 0.010, 0.00002215),
            new UnitWeight("PL", 0.0105, 0.00002442),
            new UnitWeight("PL", 0.011, 0.00002680),
            new UnitWeight("PL", 0.0115, 0.00002930),
            new UnitWeight("PL", 0.012, 0.00003190),
            new UnitWeight("PL", 0.013, 0.00003744),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", 0.0135, 0.00004037),
            new UnitWeight("PL", 0.014, 0.00004342),
            new UnitWeight("PL", 0.015, 0.00004984),
            new UnitWeight("PL", 0.016, 0.00005671),
            new UnitWeight("PL", 0.017, 0.00006402),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", 0.018, 0.00007177),
            new UnitWeight("PL", 0.019, 0.00007997),
            new UnitWeight("PL", 0.020, 0.00008861),
            //Plain Steel - Lock Twist
            new UnitWeight("PL", 0.022, 0.00010722),
            new UnitWeight("PL", 0.024, 0.00012760),
            new UnitWeight("PL", 0.026, 0.00014975),
            //Plain Steel - Soldered Twist
            new UnitWeight("KPL", 0.009, 0.00014975),
            new UnitWeight("KPL", 0.010, 0.00014975),
            new UnitWeight("KPL", 0.011, 0.00014975),
            new UnitWeight("KPL", 0.012, 0.00014975),
            new UnitWeight("KPL", 0.013, 0.00014975),
            //Plain Steel - Soldered Twist
            new UnitWeight("KPL", 0.014, 0.00004342),
            new UnitWeight("KPL", 0.016, 0.00005671),
            new UnitWeight("KPL", 0.017, 0.00006402),
            new UnitWeight("KPL", 0.020, 0.00008861),
            //Plain Steel - Double Ball End
            new UnitWeight("SPL", 0.009, 0.00001794),
            new UnitWeight("SPL", 0.010, 0.00002215),
            new UnitWeight("SPL", 0.011, 0.00002680),
            new UnitWeight("SPL", 0.013, 0.00003744),
            //Plain Steel - Double Ball End
            new UnitWeight("SPL", 0.016, 0.00005671),
            new UnitWeight("SPL", 0.017, 0.00006402),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", 0.017, 0.00005524),
            new UnitWeight("NW", 0.018, 0.00006215),
            new UnitWeight("NW", 0.019, 0.00006947),
            new UnitWeight("NW", 0.020, 0.00007495),
            new UnitWeight("NW", 0.021, 0.00008293),
            new UnitWeight("NW", 0.022, 0.00009184),
            new UnitWeight("NW", 0.024, 0.00010857),
            new UnitWeight("NW", 0.026, 0.00012671),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", 0.028, 0.00014666),
            new UnitWeight("NW", 0.030, 0.00017236),
            new UnitWeight("NW", 0.032, 0.00019347),
            new UnitWeight("NW", 0.034, 0.00021590),
            new UnitWeight("NW", 0.036, 0.00023964),
            new UnitWeight("NW", 0.038, 0.00026471),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", 0.039, 0.00027932),
            new UnitWeight("NW", 0.042, 0.00032279),
            new UnitWeight("NW", 0.044, 0.00035182),
            new UnitWeight("NW", 0.046, 0.00038216),
            new UnitWeight("NW", 0.048, 0.00041382),
            new UnitWeight("NW", 0.049, 0.00043014),
            new UnitWeight("NW", 0.052, 0.00048109),
            //XL - Nickelplated Steel Round Wound
            new UnitWeight("NW", 0.054, 0.00053838),
            new UnitWeight("NW", 0.056, 0.00057598),
            new UnitWeight("NW", 0.059, 0.00064191),
            new UnitWeight("NW", 0.060, 0.00066542),
            new UnitWeight("NW", 0.062, 0.00070697),
            new UnitWeight("NW", 0.064, 0.00074984),
            new UnitWeight("NW", 0.066, 0.00079889),
            new UnitWeight("NW", 0.068, 0.00084614),
            new UnitWeight("NW", 0.070, 0.00089304),
            new UnitWeight("NW", 0.072, 0.00094124),
            new UnitWeight("NW", 0.074, 0.00098869),
            new UnitWeight("NW", 0.080, 0.00115011),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", 0.024, 0.00010857),
            new UnitWeight("NW", 0.026, 0.00012671),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", 0.032, 0.00019347),
            new UnitWeight("NW", 0.036, 0.00023964),
            //XL - Nickelplated Steel Round Wound Steinberger
            new UnitWeight("NW", 0.042, 0.00032279),
            new UnitWeight("NW", 0.046, 0.00038216),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", 0.018, 0.00006588),
            new UnitWeight("XSG", 0.020, 0.00007919),
            new UnitWeight("XSG", 0.021, 0.00008774),
            new UnitWeight("XSG", 0.022, 0.00009731),
            new UnitWeight("XSG", 0.024, 0.00011501),
            new UnitWeight("XSG", 0.026, 0.00013419),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", 0.028, 0.00015493),
            new UnitWeight("XSG", 0.030, 0.00018203),
            new UnitWeight("XSG", 0.032, 0.00020398),
            new UnitWeight("XSG", 0.034, 0.00022729),
            new UnitWeight("XSG", 0.036, 0.00025198),
            new UnitWeight("XSG", 0.038, 0.00027804),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", 0.040, 0.00031044),
            new UnitWeight("XSG", 0.042, 0.00033924),
            new UnitWeight("XSG", 0.046, 0.00040096),
            new UnitWeight("XSG", 0.048, 0.00043387),
            new UnitWeight("XSG", 0.050, 0.00046816),
            new UnitWeight("XSG", 0.052, 0.00050382),
            //XLS - Stainless Steel Round Wound
            new UnitWeight("XSG", 0.054, 0.00056388),
            new UnitWeight("XSG", 0.056, 0.00060297),
            new UnitWeight("XSG", 0.070, 0.00092592),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", 0.022, 0.00011271),
            new UnitWeight("HRG", 0.024, 0.00012857),
            new UnitWeight("HRG", 0.026, 0.00014750),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", 0.030, 0.00018970),
            new UnitWeight("HRG", 0.032, 0.00021100),
            new UnitWeight("HRG", 0.036, 0.00025650),
            //Half Round - Stainless Steel Half Round
            new UnitWeight("HRG", 0.039, 0.00029700),
            new UnitWeight("HRG", 0.042, 0.00033400),
            new UnitWeight("HRG", 0.046, 0.00039810),
            new UnitWeight("HRG", 0.052, 0.00049500),
            new UnitWeight("HRG", 0.056, 0.00056700),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", 0.020, 0.00007812),
            new UnitWeight("CG", 0.022, 0.00009784),
            new UnitWeight("CG", 0.024, 0.00011601),
            new UnitWeight("CG", 0.026, 0.00013574),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", 0.028, 0.00014683),
            new UnitWeight("CG", 0.030, 0.00016958),
            new UnitWeight("CG", 0.032, 0.00019233),
            new UnitWeight("CG", 0.035, 0.00024197),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", 0.038, 0.00026520),
            new UnitWeight("CG", 0.040, 0.00031676),
            new UnitWeight("CG", 0.042, 0.00034377),
            new UnitWeight("CG", 0.045, 0.00040393),
            //Chromes - Stainless Steel Flat Wound
            new UnitWeight("CG", 0.048, 0.00043541),
            new UnitWeight("CG", 0.050, 0.00047042),
            new UnitWeight("CG", 0.052, 0.00049667),
            new UnitWeight("CG", 0.056, 0.00059075),
            new UnitWeight("CG", 0.065, 0.00089364)
        };
    }
}
