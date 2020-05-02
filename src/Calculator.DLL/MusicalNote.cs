using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.DLL
{
    public class MusicalNote : ICloneable
    {
        public MusicalNote(string name, int octave)
        {
            this.Name = name;
            this.Octave = octave;
            this.Frequency = (new FreqRepo()).GetMusicalNote(name, octave).Frequency;
        }

        public MusicalNote(string name, int octave, double frequency)
        {
            this.Name = name;
            this.Octave = octave;
            this.Frequency = frequency;
        }
        public MusicalNote()
        {

        }

        public string FullName => $"{Name}{Octave}";
        public string Name { get; set; }
        public int Octave { get; set; }
        public double Frequency { get; set; }

        public object Clone()
        {
            return new MusicalNote()
            {
                Name = this.Name,
                Octave = this.Octave,
                Frequency = this.Frequency
            };
        }
    }
}
