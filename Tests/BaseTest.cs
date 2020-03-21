using AutoFixture;
using AutoFixture.AutoMoq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class BaseTest
    {
        protected readonly IFixture Fixture;

        public BaseTest()
        {
            Fixture = new Fixture().Customize(new AutoMoqCustomization());
        }
    }
}
