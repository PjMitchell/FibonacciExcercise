using FibonacciExcercise.Controllers;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using Xunit;

namespace FibonacciExcercise.Tests
{
    public class FibonacciControllerTest
    {
        private readonly FibonacciController target;

        public FibonacciControllerTest()
        {
            target = new FibonacciController(NullLogger<FibonacciController>.Instance);
        }

        [Fact]
        public void N0_Returns_0()
        {
            var result = target.Get(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void N1_Returns_1()
        {
            var result = target.Get(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void N2_Returns_1()
        {
            var result = target.Get(2);
            Assert.Equal(1, result);
        }
    }
}
