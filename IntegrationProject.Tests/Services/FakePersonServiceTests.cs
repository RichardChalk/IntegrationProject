using IntegrationProject.Services;

namespace IntegrationProject.Tests.Services
{
    [TestClass]
    public class FakePersonServiceTests
    {
        [TestMethod]
        public void Generate_ReturnsValidFakePerson()
        {
            // Arrange
            var service = new FakePersonService();

            // Act
            var person = service.Generate();

            // Assert
            Assert.IsNotNull(person);
            Assert.IsFalse(string.IsNullOrEmpty(person.FirstName));
            Assert.IsFalse(string.IsNullOrEmpty(person.LastName));
            Assert.IsFalse(string.IsNullOrEmpty(person.City));
            Assert.IsFalse(string.IsNullOrEmpty(person.Country));
            Assert.IsFalse(string.IsNullOrEmpty(person.Username));
        }
    }
}