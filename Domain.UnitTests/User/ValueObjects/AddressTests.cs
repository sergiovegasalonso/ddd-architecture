using DDDArchitecture.Domain.User.ValueObjects;
using NUnit.Framework;
using System.Collections.Generic;

namespace DDDArchitecture.Domain.UnitTests.User.ValueObjects
{
    public class AddressTests
    {
        [Test]
        public void ShouldCreatedAddressesCorrectly()
        {
            string street = "Calle Huélaga 46";
            string city = "Moraleja";
            string state = "Extremadura";
            string country = "España";
            string zipcode = "10840";

            var address = new Address(street, city, state, country, zipcode);
            Assert.AreEqual(address.Street, street);
            Assert.AreEqual(address.City, city);
            Assert.AreEqual(address.State, state);
            Assert.AreEqual(address.Country, country);
            Assert.AreEqual(address.ZipCode, zipcode);
        }

        [Test]
        public void ShouldBeEqualAddresses()
        {
            var firstAddress = new Address("Calle Huélaga 46", "Moraleja", "Extremadura", "España", "10840");
            var secondAddress = new Address("Calle Huélaga 46", "Moraleja", "Extremadura", "España", "10840");

            Assert.IsTrue(EqualityComparer<Address>.Default.Equals(firstAddress, secondAddress));
            Assert.IsTrue(Equals(firstAddress, secondAddress));
            Assert.IsTrue(firstAddress.Equals(secondAddress));
            Assert.IsTrue(firstAddress == secondAddress);
        }

        [Test]
        public void ShouldNotBeEqualAddresses()
        {
            var firstAddress = new Address("Calle Huélaga 46", "Moraleja", "Extremadura", "España", "10840");
            var secondAddress = new Address("Calle Coria 2", "Moraleja", "Extremadura", "España", "10840");

            Assert.IsFalse(EqualityComparer<Address>.Default.Equals(firstAddress, secondAddress));
            Assert.IsFalse(Equals(firstAddress, secondAddress));
            Assert.IsFalse(firstAddress.Equals(secondAddress));
            Assert.IsFalse(firstAddress == secondAddress);
        }
    }
}
