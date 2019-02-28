using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roullete_russian
{
    class test
    {
        [TestCase]
        public void pos()
        {
            maingame positive = new maingame();
            Assert.AreEqual(1, positive.spiner_Chamber(6));
        }

        [TestCase]
        public void neg()
        {
            maingame negative = new maingame();
            Assert.AreNotEqual(4, negative.spiner_Chamber(6));
        }
    }
}
