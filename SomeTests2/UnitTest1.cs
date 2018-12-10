using System.Collections;
using System.Collections.Generic;

using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test1(int val)
        {
            Assert.Less(val, 1000000);
        }

        private static IEnumerable<int> TestCases
        {
            get
            {
                for (int i = 0; i < 1000; i++)
                    yield return i;
            }
        }
    }
}