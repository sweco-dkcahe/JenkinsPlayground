using JenkinsAPI.Logic;

namespace JenkinsAPITest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            //Arrange

            //Act
            int[] odds = DummyLogic.GetOddNumbers().ToArray();
            int[] even = DummyLogic.GetEvenNumbers().ToArray();
            int[] numbers = DummyLogic.GetNumbers().ToArray();

            //Assert

        }
    }
}