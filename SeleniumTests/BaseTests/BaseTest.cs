using NUnit.Framework;
using SeleniumFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]

        public void SetUp()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/text-box");

        }

        //[TearDown]

        //public void TearDown()
        //{
        //    Driver.CloseDriver();
        //}
    }
}
