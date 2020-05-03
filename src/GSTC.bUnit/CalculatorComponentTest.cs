using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using _pages = GuitarStringTensionCalculator.Pages;
using Xunit;
using Shouldly;
using Microsoft.AspNetCore.Components;

namespace GSTC.bUnit
{
    public class CalculatorComponentTest : ComponentTestFixture
    {
        [Fact]
        public void InitialHtmlIsCorrect()
        {
            // Arrange - renders the Calculator component
            var cut = RenderComponent<_pages.Calculator>();
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("0");
            cut.Find("select").Change(new ChangeEventArgs() { Value = "6" });
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
            cut.Find("select").Change(new ChangeEventArgs() { Value = "" });
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
        }
    }
}
