using Calculator.DLL;
using System.Linq;
using Xunit;

namespace GSTC.bUnit
{
    public class TuningTest
    {
        [Fact]
        public void DefaultTuning()
        {
            var tuning = new Tuning();

            Assert.Equal((new MusicalNote("E", 4)), tuning.MusicalNotes.First());
        }

        [Fact]
        public void SpecificTuning()
        {
            var tuning_minus_2 = new Tuning(-2);

            Assert.Equal((new MusicalNote("E", 4).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[0]);
            Assert.Equal((new MusicalNote("B", 3).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[1]);
            Assert.Equal((new MusicalNote("G", 3).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[2]);
            Assert.Equal((new MusicalNote("D", 3).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[3]);
            Assert.Equal((new MusicalNote("A", 2).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[4]);
            Assert.Equal((new MusicalNote("E", 2).GetPrev().GetPrev()), tuning_minus_2.MusicalNotes[5]);

            var tuning_plus_2 = new Tuning(2);

            Assert.Equal((new MusicalNote("E", 4).GetNext().GetNext()), tuning_plus_2.MusicalNotes[0]);
            Assert.Equal((new MusicalNote("B", 3).GetNext().GetNext()), tuning_plus_2.MusicalNotes[1]);
            Assert.Equal((new MusicalNote("G", 3).GetNext().GetNext()), tuning_plus_2.MusicalNotes[2]);
            Assert.Equal((new MusicalNote("D", 3).GetNext().GetNext()), tuning_plus_2.MusicalNotes[3]);
            Assert.Equal((new MusicalNote("A", 2).GetNext().GetNext()), tuning_plus_2.MusicalNotes[4]);
            Assert.Equal((new MusicalNote("E", 2).GetNext().GetNext()), tuning_plus_2.MusicalNotes[5]);
        }
    }
}
