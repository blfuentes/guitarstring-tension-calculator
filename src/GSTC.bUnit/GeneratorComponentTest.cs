using Bunit;
using GSTC.bUnit.Components;
using MudBlazor;
using MudBlazor.Services;
using Shouldly;
using Xunit;

namespace GSTC.bUnit
{
    public class GeneratorComponentTest : TestContext
    {
        [Fact]
        public void InitialHtmlIsCorrect()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();

            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PreventDuplicates = true;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
                config.PopoverOptions.ThrowOnDuplicateProvider = false;
            });

            // Act
            var component = ctx.RenderComponent<GeneratorTestWrapper>();
            var numOfStringsSelect = component.FindAll("#select-numofstrings");
            var scaleLengthSelect = component.FindAll("#select-scalelength");
            var semitonesSelect = component.FindAll("#select-semitones");
            var tuningSelect = component.FindAll("#select-tuning");

            // Assert
            component.ShouldNotBeNull();
            numOfStringsSelect.Count.ShouldBe(1);
            scaleLengthSelect.Count.ShouldBe(1);
            semitonesSelect.Count.ShouldBe(1);
            tuningSelect.ShouldBeEmpty();
        }

        [Fact]
        public void SelectNumOfStrings()
        {
            // Arrange
            using var ctx = new Bunit.TestContext();

            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PreventDuplicates = true;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
                config.PopoverOptions.ThrowOnDuplicateProvider = false;
            });

            // Act & Assert
            var component = ctx.RenderComponent<GeneratorTestWrapper>();
            var select = component.FindComponents<MudSelect<string>>()[0];
            select.Instance.Value.ShouldBeNull();

            var input = component.Find("div.mud-input-control");
            input.Click();

            var items = component.FindAll("div.mud-list-item");
            items.Count.ShouldBeGreaterThan(0);
            items[1].Click();
            select.Instance.Value.ShouldBe("7");
        }
    }
}