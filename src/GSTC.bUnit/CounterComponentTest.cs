using Xunit;
using Bunit;
using GuitarStringTensionCalculator.Components.Pages;
using Shouldly;

namespace GSTC.bUnit
{
    public class CounterComponentTest : TestContext
    {
        [Fact]
        public void InitialHtmlIsCorrect()
        {
            // Arrange - renders the Counter component
            var cut = RenderComponent<Counter>();

            // Assert
            // Here we specify expected HTML from CUT.
            var expectedHtml = @"

<h1>Counter</h1>

<p role=""status"">Current count: 0</p>

<button class=""btn btn-primary"" blazor:onclick=""1"">Click me</button>";

            // Here we use the HTML diffing library to assert that the rendered HTML
            // from CUT is semantically the same as the expected HTML string above.
            cut.MarkupMatches(expectedHtml);
        }

        [Fact]
        public void ClickingButtonIncreasesCountStrict()
        {
            // Arrange - renders the Counter component
            var cut = RenderComponent<Counter>();

            // Act
            // Use a Find to query the rendered DOM tree and find the button element
            // and trigger the @onclick event handler by calling Click
            cut.Find("button").Click();

            // Assert
            // GetChangesSinceFirstRender returns list of differences since the first render,
            // in which we assert that there should only be one change, a text change where
            // the new value is provided to the ShouldHaveSingleTextChange assert method.
            cut.GetChangesSinceFirstRender().ShouldHaveSingleTextChange("Current count: 1");

            // Repeat the above steps to ensure that counter works for multiple clicks
            cut.Find("button").Click();
            cut.GetChangesSinceFirstRender().ShouldHaveSingleTextChange("Current count: 2");
        }

        [Fact]
        public void ClickingButtonIncreasesCountTargeted()
        {
            // Arrange - renders the Counter component
            var cut = RenderComponent<Counter>();

            // Act
            // Use a Find to query the rendered DOM tree and find the button element
            // and trigger the @onclick event handler by calling Click
            cut.Find("button").Click();

            // Assert
            // Use a Find to query the rendered DOM tree and find the paragraph element
            // and assert that its text content is the expected (calling Trim first to remove insignificant whitespace)
            cut.Find("p").TextContent.Trim().ShouldBe("Current count: 1");

            // Repeat the above steps to ensure that counter works for multiple clicks
            cut.Find("button").Click();
            cut.Find("p").TextContent.Trim().ShouldBe("Current count: 2");
        }
    }
}