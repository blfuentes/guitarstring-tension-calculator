using System;
using System.Collections.Generic;

namespace Calculator.DLL
{
    public class FreqRepo
    {
        public MusicalNote GetMusicalNote(string name, int octave)
        {
            var tmpBaseNote = BaseMusicalNotes.Find(_n => _n.Name.Equals(name));
            var result = (MusicalNote)tmpBaseNote.Clone();
            result.Frequency = result.Frequency * Math.Pow(2, octave);
            result.Octave = octave;

            return result;
        }

        public List<string> BaseNoteNames => new List<string>()
        {
            "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab", "A", "A#/Bb", "B" 
        };

        private List<MusicalNote> BaseMusicalNotes => new List<MusicalNote>()
        {
            // octave 0
            new MusicalNote("C", 0, 16.351),
            new MusicalNote("C#/Db", 0,  17.324),
            new MusicalNote("D", 0,  18.354),
            new MusicalNote("D#/Eb", 0,  19.445),
            new MusicalNote("E", 0,  20.601),
            new MusicalNote("F", 0,  21.827),
            new MusicalNote("F#/Gb", 0,  23.124),
            new MusicalNote("G", 0,  24.499),
            new MusicalNote("G#/Ab", 0,  25.956),
            new MusicalNote("A", 0,  27.5),
            new MusicalNote("A#/Bb", 0, 29.135),
            new MusicalNote("B", 0,  30.868)
        };
    }
}
