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
        public void Sale_ShallowClone_ReturnsCorrectObject()
        {
            //arrange
            ISalePricingStrategy originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
            var saleOriginal = new Sale("Original", 100, originalSalePricingStrategy);

            //act
            var saleClone = (Sale)saleOriginal.ShallowClone();

            //assert
            saleClone.Should().BeEquivalentTo(saleOriginal);
            saleClone.Should().NotBeSameAs(saleOriginal);
            saleClone.ISalePricingStrategy.Should().BeSameAs(originalSalePricingStrategy);
        }
        [Test]
        public void Sale_DeepClone_ReturnsCorrectObject()
        {
            //arrange
            ISalePricingStrategy originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
            var saleOriginal = new Sale("Original", 100, originalSalePricingStrategy);

            //act
            var saleClone = (Sale)saleOriginal.DeepClone();

            //assert
            saleClone.Should().BeEquivalentTo(saleOriginal);
            saleClone.Should().NotBeSameAs(saleOriginal);
            saleClone.ISalePricingStrategy.Should().NotBeSameAs(originalSalePricingStrategy);
        }
    }
}
