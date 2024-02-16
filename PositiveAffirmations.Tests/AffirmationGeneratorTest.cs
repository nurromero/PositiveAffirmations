namespace PositiveAffirmations.Tests
{
    [TestClass]
    public class AffirmationGeneratorTest
    {
        [TestMethod]
        public void GenerateAffirmation_ReturnsPositiveAffirmation()
        {
            //Arrange
            var generator = new AffirmationGenerator();

            //Act
            string affirmation = generator.GenerateAffirmation();

            //Assert
            Assert.IsNotNull(affirmation);
            Assert.IsTrue(affirmation.Length > 0);


        }
    }
}