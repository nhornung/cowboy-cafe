using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "SpecialInstructions", () =>
            {
                corn.Size = Size.Large;
            });
        }
    }
}
