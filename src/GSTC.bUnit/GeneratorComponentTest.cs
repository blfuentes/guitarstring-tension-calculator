using Bunit;
using GSTC.bUnit.Components;
using GuitarStringTensionCalculator.Components.Pages;
using MudBlazor;
using MudBlazor.Services;
using Shouldly;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;

namespace GSTC.bUnit
{
    public class GeneratorComponentTest : TestContext
    {
        private const string ExpectedGeneratorComponentMarkupFilePath = "GSTC.bUnit.Outputs.HtmlComponents.Generator.component.output.txt";
        
        [Fact]
        public void Select()
        {
            using var ctx = new Bunit.TestContext();

            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PreventDuplicates = true;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
                config.PopoverOptions.ThrowOnDuplicateProvider = false;
            });

            var cut = ctx.RenderComponent<GeneratorTestWrapper>();
            cut.Find("div.mud-input-control").Click();
            cut.FindAll("div.mud-list-item").Count.ShouldBeGreaterThan(0); // using FluentAssertions
        }

        [Fact]
        public void InitialHtmlIsCorrect()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(ExpectedGeneratorComponentMarkupFilePath);
            using var reader = new StreamReader(stream);
            var expectedMarkup = reader.ReadToEnd();

            using var ctx = new Bunit.TestContext();

            ctx.JSInterop.Mode = JSRuntimeMode.Loose;
            ctx.Services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PreventDuplicates = true;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
                config.PopoverOptions.ThrowOnDuplicateProvider = false;
            });

            var cut = ctx.RenderComponent<GeneratorTestWrapper>();
            cut.Markup.ShouldContain(expectedMarkup);
        }
    }
}