using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using System.Threading;



namespace Cas29
{
    class Cas30Vezba : SeleniumBaseClass
    {
        private readonly FileManagement log = new FileManagement();

        public Cas30Vezba()
        {
            this.log.FileName = @"C:\Kurs\Selenium_Cas30.txt";
        }

        [Test]
        public void SeleniumEasy_InputForms_Ivica()
        {
            this.log.Store("*** Single Input Field***");
            this.NavigateTo("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            IWebElement inputField = this.FindElement(By.XPath("//input[@id='user-message']"));
            this.SendKeys("Kako napraviti SS sa Se?", false);
            this.FindElement(By.XPath("//button[contains(text(),'Show Message')]"))?.SendKeys(Keys.Enter);
            IWebElement msg = this.FindElement(By.XPath("//span[@id='display']"));
            Assert.AreEqual(inputField.GetAttribute("value"), msg.Text);
        }

        [Test]
        public void SeleniumEasy_InputForms_Aleksandar()
        {
            this.NavigateTo("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            string xPath = "//input[@id='user-message']";
            IWebElement textPolje = this.Driver.FindElement(By.XPath(xPath));
            string pojamZaPretragu = "Selenium";
            textPolje.SendKeys(pojamZaPretragu);
            IWebElement dugme = this.Driver.FindElement(By.XPath("//button[contains(text(),'Show Message')]"));
            dugme.Click();
            IWebElement expected = this.Driver.FindElement(By.XPath("//span[@id='display']"));
            Assert.AreEqual(pojamZaPretragu, expected.Text);
            Thread.Sleep(3000);
        }

        [Test]
        public void SeleniumEasy_InputForms_Filip()
        {
            this.NavigateTo("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            IWebElement tekstUnos = this.FindElement(By.Id("user-message"));
            this.SendKeys("neki tekst", false, tekstUnos);
            DoWait(2);
            IWebElement showMessage = this.FindElement(By.XPath("//button[@onclick='showInput();']"));
            showMessage.Click();
            IWebElement actualMessage = this.FindElement(By.Id("display"));
            DoWait(2);
            Assert.AreEqual(actualMessage.Text, "neki tekst");
        }

        [SetUp]
        public void SetUpTests()
        {
            this.Driver = new FirefoxDriver();
            this.Wait = 3;
        }

        [TearDown]
        public void TearDownTests()
        {
            this.Close();
        }
    }
}
