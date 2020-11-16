using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace prototype_pattern.Tests
{
    [TestFixture]
    class PrototpyeTests
    {
        [Test]
        public void Sale_Clone_ReturnsCorrectObject()
        {
            //arrange
            var saleOriginal = new Sale("Original", 100, new SalePricingStrategyFixedDiscount(80, true));

            //act
            var saleClone = saleOriginal.Clone();

            //assert
            saleClone.Should().BeEquivalentTo(saleOriginal);
            saleClone.Should().NotBeSameAs(saleOriginal);
        }
    }
}
