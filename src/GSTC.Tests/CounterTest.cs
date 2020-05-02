using GuitarStringTensionCalculator.Pages;
using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GSTC.Tests
{
    public class CounterTest : BlazorTestBase
    {
        [Fact]
        public void CountStartsAtZero()
        {
            var component = host.AddComponent<Counter>();

            Assert.Equal("Current count: 0", component.Find("p").InnerText);
        }

        [Fact]
        public void CanIncrementCount()
        {
            var component = host.AddComponent<Counter>();

            component.Find("button").Click();
            Assert.Equal("Current count: 1", component.Find("p").InnerText);
        }
    }
}
