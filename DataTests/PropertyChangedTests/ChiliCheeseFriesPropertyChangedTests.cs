using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "SpecialInstructions", () =>
            {
                fries.Size = Size.Large;
            });
        }
    }
}
