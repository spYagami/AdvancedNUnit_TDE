using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    //[Ignore("Not using these tests yet")]
    public class CounterTests
    {
        private Counter _sut;
        
        [SetUp]
        public void SetUp()
        {
            _sut = new Counter(0);
        }
        
        [Test]
        public void Increment_IncreaseCountByOne()
        {
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(-1));
        }
        
        [Category("AddCases")]
        [TestCaseSource("_addCases")]
        public void Add_Always_ReturnsResult_WithDataProvider(int x, int y, int expResult)
        {
            var subject = new Calculator {Num1 = x, Num2 = y};
            Assert.That(subject.Add(), Is.EqualTo(expResult));
        }

        private static object[] _addCases =
        {
            new int[] {2,4,6},
            new int[] {-2,3,1},
            new int[] {3,3,6},
            new int[] {33,3,36}
        };

    }
}
