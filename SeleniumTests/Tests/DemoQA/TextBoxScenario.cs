using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.DemoQA
{
    internal class TextBoxScenario : BaseTest
    {
        [Test]
        public void TextBoxesCorrectlySubmitedAndDisplayed()
        {
            string fullName = "Kotryna";
            string email = "kotryna@jee.vom";
            string currentAddress = "gatve 2, paryzius, ispanija, europa";
            string permanentAddress = "gatve 1, kaunas, ispanija";

            TextBoxPage.InputFullName(fullName);
            TextBoxPage.InputEmail(email);
            TextBoxPage.InputCurrentAddress(currentAddress);
            TextBoxPage.InputPermanentAddress(permanentAddress);
            TextBoxPage.ClickSubmitButton();
            string actualResult = TextBoxPage.GetTextOutput();
            
            StringAssert.Contains(fullName, actualResult);
            StringAssert.Contains(email, actualResult);
            StringAssert.Contains(currentAddress, actualResult);
            StringAssert.Contains(permanentAddress, actualResult);
        }

        [Test]
        public void TextBoxEmailIncorrectlyInputed()
        {
            string expectedEmailBoxBorderColor = "rgb(255, 0, 0)";
            string incorrectEmail = "kotryna@jjj";

            TextBoxPage.InputIncorrectEmail(incorrectEmail);
            TextBoxPage.ClickSubmitButton();
            TextBoxPage.WaitForEmailBoxBorderColorToBe(expectedEmailBoxBorderColor);
            string actualEmailBoxColor = TextBoxPage.GetEmailBoxBorderColor();

            Assert.AreEqual(actualEmailBoxColor, expectedEmailBoxBorderColor);
        }
    }
}
