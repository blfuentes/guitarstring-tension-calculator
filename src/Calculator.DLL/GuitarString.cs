using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.DLL
{
    public class GuitarString
    {
        public GuitarString(string prefix, string diameter, double length, MusicalNote note, StringMaterial material)
        {
            this.Diameter = double.Parse($"0.{diameter}") * _PULGADA_;
            this.Length_INCH = length;
            //this.Length = length * _PULGADA_;
            this.Note = note;
            this.Material = material;
            this.Prefix = prefix;
            this.UW = UnitWeightRepo.GetUnitWeight(prefix, diameter);
        }

        public GuitarString()
        {

        }
        const double _NEWTON_ = 0.1019716213;
        const double _PULGADA_ = 0.0254;
        const double _LIBRA_ = 2.204620823516057;

        public double Diameter { get; set; } // mm
        public double Diameter_INCH => Diameter / _PULGADA_;

        public double Length => Length_INCH * _PULGADA_; // m
        public double Length_MM => Math.Round(Length * 1000, 2);
        public double Length_INCH { get; set; }

        public string LengthDisplay => $"{Length_INCH}\"/{Length_MM}mm";

        public string Prefix { get; set; }
        public MusicalNote Note { get; set; }
        public StringMaterial Material { get; set; }
        public UnitWeight UW { get; set; }

        public string TensionDisplay => $"{Math.Round(StringTension_UW_LB, 1)}LB/{Math.Round(StringTension_UW_KG, 1)}Kg";

        #region METHOD_1
        // M = π* (0.5 * d)^2 * ρ
        public double MassPerUnitOfLength => Math.PI * Math.Pow(0.5 * Diameter, 2) * Material.Density;

        // T = 4 * F^2 * L^2 * π * (0.5*d)^2 * ρ
        //public double StringTension => 4 * Math.Pow(Note.Frequency, 2) * Math.Pow(Length, 2) * MassPerUnitOfLength;
        public double StringTension_KG => _NEWTON_ * Math.Pow(Diameter / 1000.0 * Length * Note.Frequency * Math.Sqrt(Math.PI * Material.Density), 2);
        public double StringTension_LB => StringTension_KG * _LIBRA_;
        #endregion

        #region METHOD_2
        // T (Tension) = (UW x (2 x L x F)^2) / 386.4
        public double StringTension_UW_KG => StringTension_UW_LB / _LIBRA_;
        public double StringTension_UW_LB => (UW.Value * Math.Pow(2 * (Length / _PULGADA_) * Note.Frequency, 2)) / 386.4;
        #endregion

    }
}
