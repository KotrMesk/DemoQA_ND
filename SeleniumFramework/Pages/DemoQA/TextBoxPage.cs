namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBoxPage
    {
        private static string boxToChangeColorLocator = "//*[@class='mr-sm-2 field-error form-control']";
        private static string outputBoxLocator = "//*[@id='output']";

        public static void ClickSubmitButton()
        {
            string locator = "//*[@class='btn btn-primary']";
            Common.ScrollUntilElementIsClickableAndClickElement(locator);
        }
        
        public static void WaitForEmailBoxBorderColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(boxToChangeColorLocator, "border-color", expectedColor);
        }

        public static string GetEmailBoxBorderColor()
        {
            return Common.GetElementCssAttributeValue(boxToChangeColorLocator, "border-color");
        }

        public static string GetTextOutput()
        {
            return Common.GetElementText(outputBoxLocator);
        }

        public static void InputCurrentAddress(string currentAddress)
        {
            string locator = "//*[@placeholder='Current Address']";
            Common.SendKeys(locator, currentAddress);
        }

        public static void InputEmail(string email)
        {
            string locator = "//*[@type='email']";
            Common.SendKeys(locator, email);
        }

        public static void InputFullName(string fullName)
        {
            string locator = "//*[@placeholder='Full Name']";
            Common.SendKeys(locator, fullName);
        }

        public static void InputIncorrectEmail(string incorrectEmail)
        {
            string locator = "//*[@type='email']";
            Common.SendKeys(locator, incorrectEmail);
        }

        public static void InputPermanentAddress(string permanentAddress)
        {
            string locator = "(//*[@id='permanentAddress'])[1]";
            Common.SendKeys(locator, permanentAddress);
        }
    }
}
