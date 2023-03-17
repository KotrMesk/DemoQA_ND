using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public class Driver
    {
        static IWebDriver driver;
        
        public static void SetupDriver()
        {
            driver = new ChromeDriver();
                        
        }
        public static IWebDriver GetDriver()
        {
            return driver;

        }
        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
