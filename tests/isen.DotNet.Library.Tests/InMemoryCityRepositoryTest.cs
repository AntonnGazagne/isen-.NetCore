using System;
using System.Collections.Generic;
using Xunit;
using isen.DotNet.Library.Repositories.InMemory;

namespace isen.DotNet.Library.Tests
{
    public class InMemoryCityRepositoryTest
    {
        [Fact]
        public void SingleById()
        {
            var cityRepository = new InMemoryCityRepository();

            var city1 = cityRepository.Single(1);
            Assert.True(city1.Id == 1);

            var noCity = cityRepository.Single(42);
            Assert.True(noCity == null);
        }

        [Fact]
        public void SingleByName()
        {
            var cityRepository = new InMemoryCityRepository();

            var city1 = cityRepository.Single("Toulon");
            Assert.True(city1.Name == "Toulon");

            var fake = cityRepository.Single("Fake");
            Assert.True(fake == null);
        }
    }
}