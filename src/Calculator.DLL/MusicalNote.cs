using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.DLL
{
    public class MusicalNote : ICloneable
    {
        public MusicalNote(string name, int octave)
        {
            this.Name = name;
            this.Octave = octave;
            _freqrepo = new FreqRepo();
            this.Frequency = _freqrepo.GetMusicalNote(name, octave).Frequency;
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

        private FreqRepo _freqrepo;

        public string FullName => $"{Name}{Octave}";
        public string Name { get; set; }
        public int Octave { get; set; }
        public double Frequency { get; set; }

        public MusicalNote GetPrev()
        {
            var prev = new MusicalNote();

            //
            if (Name == "C" && Octave == 0)
                return null;

            //
            var idx = _freqrepo.BaseNoteNames.IndexOf(this.Name);
            if (idx == 0)
            {
                prev.Name = _freqrepo.BaseNoteNames.Last();
                prev.Octave = this.Octave - 1;
            }
            else
            {
                prev.Name = _freqrepo.BaseNoteNames.ElementAt(idx - 1);
                prev.Octave = this.Octave;
            }

            //
            prev.Frequency = _freqrepo.GetMusicalNote(prev.Name, prev.Octave).Frequency;

            //
            return prev;
        }

        public MusicalNote GetNext()
        {
            var next = new MusicalNote();

            //
            if (Name == "B" && Octave == 9)
                return null;

            //
            var idx = _freqrepo.BaseNoteNames.IndexOf(this.Name);
            if (idx == _freqrepo.BaseNoteNames.Count - 1)
            {
                next.Name = _freqrepo.BaseNoteNames.First();
                next.Octave = this.Octave + 1;
            }
            else
            {
                next.Name = _freqrepo.BaseNoteNames.ElementAt(idx + 1);
                next.Octave = this.Octave;
            }

            //
            next.Frequency = _freqrepo.GetMusicalNote(next.Name, next.Octave).Frequency;

            //
            return next;
        }

        public object Clone()
        {
            return new MusicalNote()
            {
                Name = this.Name,
                Octave = this.Octave,
                Frequency = this.Frequency
            };
        }

        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                MusicalNote musicalNote = (MusicalNote)obj;
                return 
                    (Name == musicalNote.Name) && 
                    (Octave == musicalNote.Octave) && 
                    (Frequency == musicalNote.Frequency);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
