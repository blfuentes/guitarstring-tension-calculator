using Bunit;
using System;
using System.Collections.Generic;
using System.Text;
using _pages = GuitarStringTensionCalculator.Core.Pages;
using Xunit;
using Shouldly;
using Microsoft.AspNetCore.Components;

namespace GSTC.bUnit
{
    public class GeneratorComponentTest : TestContext
    {
        [Fact]
        public void InitialHtmlIsCorrect()
        {
            // Arrange - renders the Generator component
            var cut = RenderComponent<_pages.Generator>();
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("0");
            cut.Find("select").Change(new ChangeEventArgs() { Value = "6" });
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
            cut.Find("select").Change(new ChangeEventArgs() { Value = "" });
            cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
        }
    }
}
