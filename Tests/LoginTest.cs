using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxuallyTest.Common;

namespace TaxuallyTest.Tests
{
    internal class LoginTest : TestBase
    {
        [Test]
        public void LoginToPage()
        {
            var email = "vizak-karikak.0q@icloud.com";
            var password = "Asde234!re5?";
            var expectedMessage = "Balint Foldi";


            var message =
                LoginTo
                .AddEmail(email)
                .AddPassword(password)
                .PressSignIn()
                .GetUserName();
            Assert.That(message, Is.EqualTo(expectedMessage));
        }
    }
}
