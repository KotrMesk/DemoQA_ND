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
            
            string expectedResult = $"Name:{fullName}\nEmail:{email}\nCurrent Address:{currentAddress}\nPermananet Address:{permanentAddress}";

            TextBoxPage.Open();
            TextBoxPage.InputFullName(fullName);
            TextBoxPage.InputEmail(email);
            TextBoxPage.InputCurrentAddress(currentAddress);
            TextBoxPage.InputPermanentAddress(permanentAddress);
            TextBoxPage.ClickSubmitButton();
            string actualRestult = TextBoxPage.GetTextOutput();
            Assert.AreEqual(expectedResult, actualRestult);
        }

        [Test]

        public void TextBoxEmailIncorrectlyInputed()
        {
            string expectedEmailBoxBorderColor = "0.666667px solid rgb(255, 0, 0)";
            string incorrectEmail = "kotryna@jjj";
            TextBoxPage.Open();
            TextBoxPage.InputIncorrectEmail(incorrectEmail);
            TextBoxPage.ClickSubmitButton();
            System.Threading.Thread.Sleep(1000);
            string actualEmailBoxColor = TextBoxPage.GetEmailBoxBorderColor();

            Assert.AreEqual(actualEmailBoxColor, expectedEmailBoxBorderColor);
        }
    }
}
