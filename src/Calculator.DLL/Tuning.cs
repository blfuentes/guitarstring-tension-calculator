using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator.DLL
{
    public class Tuning
    {
        public Tuning(int semitones)
        {

            this.Semitones = semitones;
            this.MusicalNotes = new List<MusicalNote>();

            int stop = Math.Abs(semitones);

            if (semitones <= 0)
            {
                _defaultStandard.ForEach(_m =>
                {
                    int cc = 0;
                    var tmpMusicalNote = (MusicalNote)_m.Clone();
                    while (cc < stop)
                    {
                        tmpMusicalNote = tmpMusicalNote.GetPrev();
                        cc++;
                    }
                    this.MusicalNotes.Add(tmpMusicalNote);
                });
            }
            else
            {
                _defaultStandard.ForEach(_m =>
                {
                    int cc = 0;
                    var tmpMusicalNote = (MusicalNote)_m.Clone();
                    while (cc < stop)
                    {
                        tmpMusicalNote = tmpMusicalNote.GetNext();
                        cc++;
                    }
                    this.MusicalNotes.Add(tmpMusicalNote);
                });
            }

            this.Name = $"{this.MusicalNotes.First().Name} Standard";
        }

        public Tuning()
        {
            this.MusicalNotes = new List<MusicalNote>();
            _defaultStandard.ForEach(_m => this.MusicalNotes.Add((MusicalNote)_m.Clone()));
        }

        private List<MusicalNote> _defaultStandard => new List<MusicalNote>()
        {
            new MusicalNote("E", 4),
            new MusicalNote("B", 3),
            new MusicalNote("G", 3),
            new MusicalNote("D", 3),
            new MusicalNote("A", 2),
            new MusicalNote("E", 2),
            new MusicalNote("B", 1),
            new MusicalNote("F#/Gb", 1),
            new MusicalNote("C#/Db", 1),
        };

        public string Name { get; set; }
        public int Semitones { get; set; }
        public List<MusicalNote> MusicalNotes { get; set; }

        public override string ToString()
        {
            return $"{this.Name} ({this.Semitones})";
        }
    }
}
