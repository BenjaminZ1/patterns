using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
            var originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
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
            var originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
            var saleOriginal = new Sale("Original", 100, originalSalePricingStrategy);

            //act
            var saleClone = (Sale)saleOriginal.DeepClone();

            //assert
            saleClone.Should().BeEquivalentTo(saleOriginal);
            saleClone.Should().NotBeSameAs(saleOriginal);
            saleClone.ISalePricingStrategy.Should().NotBeSameAs(originalSalePricingStrategy);
        }

        [Test]
        public void Sale_ShallowClone_GeneratedObjectReturnsCorrectResult()
        {
            //arrange
            var originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
            var saleOriginal = new Sale("Original", 100, originalSalePricingStrategy);

            var saleClone = (Sale)saleOriginal.ShallowClone();

            //act
            var result = saleClone.GetTotal();

            //assert
            result.Should().Be(20);
        }

        [Test]
        public void Sale_DeepClone_GeneratedObjectReturnsCorrectResult()
        {
            //arrange
            var originalSalePricingStrategy = new SalePricingStrategyFixedDiscount(80, true);
            var saleOriginal = new Sale("Original", 100, originalSalePricingStrategy);

            var saleClone = (Sale) saleOriginal.DeepClone();

            //act
            var result = saleClone.GetTotal();

            //assert
            result.Should().Be(20);
        }

        [Test]
        public void Flup()
        {
            var sale = new Sale.SaleB();
            sale.GetTotal();
            var clone = sale.DeepClone();
        }
            
        
    }
}
