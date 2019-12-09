using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Cas29
{
    class Tests : SeleniumBaseClass
    {
        private readonly FileManagement log = new FileManagement();

        public Tests()
        {
            this.log.FileName = @"C:\Kurs\Selenium_Cas29.txt";
        }

        [Test]
        public void PerformGoogleSearch()
        {
            this.log.Store("*** PerformGoogleSearch ***");
            this.NavigateTo("http://www.google.rs/");
            IWebElement el = this.FindElement(By.Name("qqq"));
            try {
                this.SendKeys("Selenium C# Helpers", true, el);
            } catch (Exception e)
            {
                this.log.Store($"Exception <{e.Message}>");
                Assert.Fail("Couldn't send keys, element not defined.");
                return;
            }
            Assert.Pass("Keys sent");
            this.DoWait(2);
        }

        [Test]
        public void SelectHawaii()
        {
            this.log.Store("*** SelectHawaii ***");
            this.NavigateTo("http://qa.todorowww.net/register");
            IWebElement el = this.FindElement(By.Name("summer"));
            var select = new SelectElement(el);
            select.SelectByText("Havaji, SAD");
            this.DoWait(2);
        }

        [Test]
        public void ClickOnRadioButtons()
        {
            this.log.Store("*** ClickOnRadioButtons ***");
            this.NavigateTo("http://qa.todorowww.net/register");
            var elements = this.FindElements(By.XPath("//input[@type='radio']"));
            foreach (var el in elements)
            {
                el.Click();
                this.DoWait(1);
            }
        }

        [Test]
        public void CheckAllVolimCheckboxes()
        {
            this.log.Store("*** CheckAllVolimCheckboxes ***");
            this.NavigateTo("http://qa.todorowww.net/register");
            var elements = this.FindElements(By.Name("volim[]"));
            foreach (var el in elements)
            {
                el.Click();
                this.DoWait(1);
            }
        }

        [Test]
        public void ExtractYearsFromTable()
        {
            this.log.Store("*** ExtractYearsFromTable ***");
            this.NavigateTo("https://www.toolsqa.com/automation-practice-table/");
            IWebElement table = this.FindElement(By.ClassName("tsc_table_s13"));
            var columns = FindElements(By.XPath("//tbody/tr/td[4]"), table);
            
            foreach(var col in columns)
            {
                this.log.Store("Pronasao godinu: " + col.Text);
            }
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
