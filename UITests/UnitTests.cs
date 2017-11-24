using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestFixture]
    public class JSChromeTestN
    {
        static IWebDriver web = null;

        [OneTimeSetUp]
        public static void Setup()
        {

            web = new ChromeDriver();

            web.Navigate().GoToUrl("http://localhost:63818/Home/CalcButtons");
        }

        [SetUp]
        public void RefreshWeb()
        {
            web.Navigate().Refresh();
        }

        [OneTimeTearDown]
        public static void QuitWeb()
        {

            web.Quit();

        }
        
        [TestCase("num1", "1")]
        [TestCase("num2", "2")]
        [TestCase("num3", "3")]
        [TestCase("num4", "4")]
        [TestCase("num5", "5")]
        [TestCase("num6", "6")]
        [TestCase("num7", "7")]
        [TestCase("num8", "8")]
        [TestCase("num9", "9")]
        [TestCase("num0", "0")]
        [TestCase("op_minus", "-")]
        [TestCase("op_plus", "+")]
        [TestCase("op_multiply", "*")]
        [TestCase("op_divide", "/")]
        [TestCase("calculate", "=")]
        [TestCase("answer", "")]
        public void JSTestChrome(string button, string result)
        {
            IWebElement webel = web.FindElement(By.Id(button));

            Assert.AreEqual(result, webel.GetAttribute("value"));
        }
        
        [TestCase("num1", "1")]
        [TestCase("num2", "2")]
        [TestCase("num3", "3")]
        [TestCase("num4", "4")]
        [TestCase("num5", "5")]
        [TestCase("num6", "6")]
        [TestCase("num7", "7")]
        [TestCase("num8", "8")]
        [TestCase("num9", "9")]
        [TestCase("num0", "0")]
        public void JSTestCalcChromeSeimpleCheck(string button, string result)
        {
            web.FindElement(By.Id(button)).Click();
            string res = web.FindElement(By.Id("answer")).GetAttribute("value");
            Assert.AreEqual(result, res);
        }
        
        [TestCase("num1", "num3", "13")]
        [TestCase("num2", "num4", "24")]
        [TestCase("num3", "num6", "36")]
        [TestCase("num4", "num7", "47")]
        [TestCase("num5", "num4", "54")]
        [TestCase("num6", "num2", "62")]
        [TestCase("num7", "num3", "73")]
        [TestCase("num8", "num3", "83")]
        [TestCase("num9", "num2", "92")]
        [TestCase("num0", "num9", "09")]
        public void JSTestCalcChromeComplexCheck(string firstbutton, string secondbutton, string result)
        {
            web.FindElement(By.Id(firstbutton)).Click();
            web.FindElement(By.Id(secondbutton)).Click();
            string res = web.FindElement(By.Id("answer")).GetAttribute("value");
            Assert.AreEqual(result, res);
        }
        
        [TestCase("num1", "op_minus", "num5", "-4")]
        [TestCase("num7", "op_plus", "num5", "12")]
        [TestCase("num5", "op_multiply", "num6", "30")]
        [TestCase("num6", "op_divide", "num3", "2")]
        public void JSTestCalcChromeRealJob(string firstbutton, string operation, string secondbutton, string result)
        {
            web.FindElement(By.Id(firstbutton)).Click();
            web.FindElement(By.Id(operation)).Click();
            web.FindElement(By.Id(secondbutton)).Click();
            web.FindElement(By.Id("calculate")).Click();
            string res = web.FindElement(By.Id("answer")).GetAttribute("value");
            Assert.AreEqual(result, res);
        }
    }
}
