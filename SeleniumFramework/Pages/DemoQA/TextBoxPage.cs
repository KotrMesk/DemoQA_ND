using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBoxPage
    {
        private static string boxToChangeColorLocator = "//*[@class='mr-sm-2 field-error form-control']";
        private static string outputBoxLocator = "//*[@class='border col-md-12 col-sm-12']";




        public static void ClickSubmitButton()
        {
            string locator = "//*[@class='btn btn-primary']";
            Common.ClickElement(locator);
        }

        public static string GetEmailBoxBorderColor()
        {
            return Common.GetElementCssAttributeValue(boxToChangeColorLocator, "border");
        }

        public static string GetTextOutput()
        {
            return Common.GetElementCssAttributeValue(outputBoxLocator, "body");
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

        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/text-box");
        }
    }
}
