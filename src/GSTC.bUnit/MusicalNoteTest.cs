using Calculator.DLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GSTC.bUnit
{
    public class MusicalNoteTest
    {
        [Fact]
        public void GetPrev()
        {
            var firstNote = new MusicalNote("C", 0).GetPrev();
            
            var middleNote = new MusicalNote("A#/Bb", 5).GetPrev();
            var middleNoteCheck = new MusicalNote("A", 5);

            var middleNotePrevOctave = new MusicalNote("C", 4).GetPrev();
            var middleNotePrevOctaveCheck = new MusicalNote("B", 3);

            var lastNote = new MusicalNote("B", 9).GetPrev();
            var lastNoteCheck = new MusicalNote("A#/Bb", 9);

            Assert.Null(firstNote);
            Assert.True(middleNote.Equals(middleNoteCheck));
            Assert.True(middleNotePrevOctave.Equals(middleNotePrevOctaveCheck));
            Assert.True(lastNote.Equals(lastNoteCheck));
        }

        [Fact]
        public void GetNext()
        {
            var lastNote = new MusicalNote("B", 9).GetNext();

            var middleNote = new MusicalNote("A#/Bb", 5).GetNext();
            var middleNoteCheck = new MusicalNote("B", 5);

            var middleNoteNextOctave = new MusicalNote("B", 4).GetNext();
            var middleNoteNextOctaveCheck = new MusicalNote("C", 5);

            var firstNote = new MusicalNote("C", 0).GetNext();
            var firstNoteCheck = new MusicalNote("C#/Db", 0);

            Assert.Null(lastNote);
            Assert.True(middleNote.Equals(middleNoteCheck));
            Assert.True(middleNoteNextOctave.Equals(middleNoteNextOctaveCheck));
            Assert.True(firstNote.Equals(firstNoteCheck));
        }
    }
}
