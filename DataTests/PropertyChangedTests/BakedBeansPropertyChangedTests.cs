using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSpecialInstructions()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "SpecialInstructions", () =>
            {
                beans.Size = Size.Large;
            });
        }
    }
}
