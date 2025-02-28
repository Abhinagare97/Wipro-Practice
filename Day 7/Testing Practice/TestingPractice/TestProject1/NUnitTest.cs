using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMaths;

namespace NUnitTesting
{
    [TestFixture]
    internal class NUnitTest
    {
       
        Class1 c = new Class1();
        [Test]
        public void TestAdd()
        {
            int result = c.add(3, 3);
            int expected = 6;
            Assert.That(result.Equals(expected));

        }

    }
}
