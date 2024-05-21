using Bunit;
using _pages = GuitarStringTensionCalculator.Components.Pages;
using Xunit;
using Shouldly;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using MudBlazor;
using System.Linq;

namespace GSTC.bUnit
{
    public class GeneratorComponentTest : TestContext
    {
        [Fact]
        public void InitialHtmlIsCorrect()
        {
            Services.AddMudServices();
            Services.AddMudBlazorKeyInterceptor();

            JSInterop.SetupVoid("mudPopover.initialize", _ => true);
            JSInterop.SetupVoid("mudPopover.connect", _ => true);
            JSInterop.SetupVoid("mudKeyInterceptor.connect", _ => true);
            JSInterop.SetupVoid("mudKeyInterceptor.updatekey", _ => true);

            // Arrange - renders the Generator component
            var comp = RenderComponent<_pages.Generator>();
            var select = comp.FindComponent<MudSelect<string>>();
            //var menu = comp.Find("div.mud-popover");
            var input = comp.Find("div.mud-input-control");
            // check popover class
            //menu.ClassList.ShouldContain("select-popover-class");
            // check initial state
            select.Instance.Value.ShouldBeNullOrEmpty();
            input.Click();
            comp.WaitForAssertion(() => comp.FindAll("div.mud-list-item").Count.ShouldBeGreaterThan(0));
            var items = comp.FindAll("div.mud-list-item").ToArray();
            items[1].Click();
            select.Instance.Value.ShouldBe("7");

            //cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("0");
            //cut.Find("select").Change(new ChangeEventArgs() { Value = "6" });
            //cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
            //cut.Find("select").Change(new ChangeEventArgs() { Value = "" });
            //cut.Find("#_result_numberofstrings").GetAttribute("value").ShouldBe("6");
        }
    }
}
