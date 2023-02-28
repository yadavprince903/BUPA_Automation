using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;

namespace BUPA
{
    [TestClass]
    public class BUPA_Health
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(); 
            driver.Navigate().GoToUrl("https://www.bupa.com.au/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.TagName("shared-ui.mega-menu")).GetShadowRoot().FindElement(By.CssSelector("a[href='https://www.bupa.com.au/health-insurance']")).Click();
            Thread.Sleep(1000);

            /*IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));*/
            String currenturl = driver.Url;

            Assert.AreEqual("https://www.bupa.com.au/health-insurance", currenturl);
            driver.Close();

           



        }
    }
}