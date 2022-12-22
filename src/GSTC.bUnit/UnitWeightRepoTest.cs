using Calculator.DLL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GSTC.bUnit
{
    public class UnitWeightRepoTest
    {
        [Fact]
        public void GetUnitWeight()
        {
            var tmp_PL007 = UnitWeightRepo.GetUnitWeight("PL", 0.007);
            var tmp_PL013 = UnitWeightRepo.GetUnitWeight("PL", 0.013);
            var tmp_PL017 = UnitWeightRepo.GetUnitWeight("PL", 0.017);
            var tmp_NW022 = UnitWeightRepo.GetUnitWeight("NW", 0.022);
            var tmp_NW034 = UnitWeightRepo.GetUnitWeight("NW", 0.034);
            var tmp_NW046 = UnitWeightRepo.GetUnitWeight("NW", 0.046);

            Assert.Equal(0.00001085, tmp_PL007.Value);
            Assert.Equal(0.00003744, tmp_PL013.Value);
            Assert.Equal(0.00006402, tmp_PL017.Value);
            Assert.Equal(0.00009184, tmp_NW022.Value);
            Assert.Equal(0.00021590, tmp_NW034.Value);
            Assert.Equal(0.00038216, tmp_NW046.Value);
        }
    }
}
