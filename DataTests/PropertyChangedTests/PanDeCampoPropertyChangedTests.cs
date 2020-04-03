using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () =>
            {
                pan.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "SpecialInstructions", () =>
            {
                pan.Size = Size.Large;
            });
        }
    }
}
