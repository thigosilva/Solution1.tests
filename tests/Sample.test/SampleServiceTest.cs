﻿using Xunit;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arrange (qualque tipo de variável necessária para montar o teste)
            _sampleService = new SampleService();
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsOdd_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_Returntrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }
    }
}