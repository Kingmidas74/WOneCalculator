using System;
using System.Threading.Tasks;
using BusinessServices.Exceptions;
using BusinessServices.Modules.CalculatorModule.Division;
using FluentAssertions;
using NUnit.Framework;

using static Testing;

namespace BusinessServices.IntegrationTests
{   
    public class CreateParentsTests:TestBase
    {
        [Test]
        public async Task ShouldReturnValidResult()
        {
            var command = new DivisionCommand() {
                FirstOperand=2,
                SecondOperand=5
            };

            var result = await SendAsync(command);
            Assert.AreEqual(2/5,result,0.01);
        }

        [Test]
        public void ShouldThrowValidationException()
        {
            var command = new DivisionCommand() {
                FirstOperand=2,
                SecondOperand=5
            };

            FluentActions.Invoking(()=> SendAsync(command)).Should().Throw<BusinessValidationException>();
    }
}
}