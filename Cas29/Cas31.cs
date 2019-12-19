using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Cas29
{
    class Cas31:SeleniumBaseClass
    {
        [Test]
        public void Test1_Filip()
        {
            this.NavigateTo("https://www.toolsqa.com/automation-practice-form");

            DoWait(3);
            DismissCookieWarning();

            IWebElement firstName = this.FindElement(By.XPath("//input[@name='firstname']"));
            this.SendKeys("Ime", false, firstName);
            IWebElement lastName = this.FindElement(By.Id("lastname"));
            this.SendKeys("Prezime", false, lastName);
            DoWait(1);
            IWebElement gender = this.FindElement(By.Id("sex-0"));
            gender.Click();
            DoWait(1);
            IWebElement experience = this.FindElement(By.Id("exp-6"));
            experience.Click();
            DoWait(1);
            IWebElement datepick = this.FindElement(By.Id("datepicker"));
            this.SendKeys(DateTime.Today.ToString(), false, datepick);

            // Catches ad popup
            DoWait(12);
            DismissAdPopup();

            DoWait(1);
            IWebElement profession = this.FindElement(By.XPath("//input[@name='profession' and @value='Automation Tester']"));


            profession.Click();
            DoWait(1);
            IWebElement tool = this.FindElement(By.Id("tool-2"));
            tool.Click();
            DoWait(1);
            IWebElement continent = this.FindElement(By.Id("continents"));
            var selection = new SelectElement(continent);
            selection.SelectByText("Europe");
            DoWait(2);
        }

        [Test]
        public void Test2_Filip()
        {
            this.NavigateTo("http://test.qa.rs/");
            this.FindElement(By.LinkText("Kreiraj novog korisnika"))?.Click();
            this.FindElement(By.Name("ime"))?.SendKeys("Dragan");
            this.FindElement(By.Name("prezime"))?.SendKeys("Jovic");
            this.FindElement(By.Name("korisnicko"))?.SendKeys("draganjovic1990");
            this.FindElement(By.Name("email"))?.SendKeys("draganjovic@gmail.com");
            this.FindElement(By.Name("telefon"))?.SendKeys("063/9090000");
            IWebElement zemlja = this.FindElement(By.Name("zemlja"));
            var selection = new SelectElement(zemlja);
            selection.SelectByValue("bih");
            DoWait(2);
            this.FindElement(By.XPath("//input[@name='pol' and @value='m']"))?.Click();
            this.FindElement(By.Name("obavestenja"))?.Click();
            this.FindElement(By.Name("promocije"))?.Click();
            this.FindElement(By.Name("register"))?.Click();
            DoWait(2);

            IWebElement success = this.FindElement(By.XPath("//div[@class='alert alert-success' and @role='alert']"));
            if (success != null)
            {
                Assert.Pass("Korisnik je uspesno registrovan i test je prosao");
            }
            else
            {
                Assert.Fail("Korisnik nije mogao da bude registrovan i test nije prosao");
            }
        }

        [Test]
        public void Test1_Marina()
        {
            this.NavigateTo("https://www.toolsqa.com/automation-practice-form/");

            DoWait(3);
            DismissCookieWarning();

            IWebElement name = this.FindElement(By.XPath("//input[@name = 'firstname']"));
            this.DoWait(3);
            string unos = "marina";
            SendKeys(unos, false, name);
            this.DoWait(1);
            IWebElement LastName = this.FindElement(By.XPath("//input[@id = 'lastname']"));
            string unos1 = "kanjuga";
            SendKeys(unos1, false, LastName);
            this.DoWait(1);
            this.FindElement(By.XPath("//input[@id = 'sex-1' and @value = 'Female']"))?.Click();
            this.DoWait(1);
            this.FindElement(By.XPath("//input[@id = 'exp-0' and @value = '1']"))?.Click();
            this.DoWait(3);
            IWebElement data = this.FindElement(By.XPath("//input[@id = 'datepicker']"));
            this.DoWait(1);
            string unos2 = "16.12.2019.";
            SendKeys(unos2, false, data);

            this.DoWait(11);
            DismissAdPopup();

            this.DoWait(1);
            this.FindElement(By.XPath("//input[@id = 'profession-1' and @value = 'Automation Tester']"))?.Click();
            this.DoWait(1);
            this.FindElement(By.XPath("//input[@id = 'tool-1' and @value = 'Selenium IDE']"))?.Click();
            this.DoWait(1);
            string selectByText = "Europe";
            IWebElement el = this.FindElement(By.Id("continents"));
            var select = new SelectElement(el);
            select.SelectByText(selectByText);
            this.DoWait(1);
            string selectByText1 = "Europe";
            IWebElement el1 = this.FindElement(By.Id("continentsmultiple"));
            var select1 = new SelectElement(el1);
            select1.SelectByText(selectByText1);
            this.DoWait(1);
            string selectByText2 = "Browser Commands";
            IWebElement el2 = this.FindElement(By.Id("selenium_commands"));
            var select2 = new SelectElement(el2);
            select2.SelectByText(selectByText2);
            this.DoWait(5);
        }

        [Test]
        public void Test2_Marina()
        {
            this.NavigateTo("http://test.qa.rs/");
            this.DoWait(3);
            this.FindElement(By.XPath("//a[@href = '/new']"))?.Click();
            IWebElement name = this.FindElement(By.XPath("//input[@name = 'ime']"));
            string unos = "marina";
            SendKeys(unos, false);
            IWebElement LastName = this.FindElement(By.XPath("//input[@name = 'prezime']"));
            string unos1 = "kanjuga";
            SendKeys(unos1, false);
            IWebElement UserName = this.FindElement(By.XPath("//input[@name = 'korisnicko']"));
            string unos2 = "marinakanjuga";
            SendKeys(unos2, false);
            IWebElement eMail = this.FindElement(By.XPath("//input[@name = 'email']"));
            string unos3 = "marinakanjuga@gmail.com";
            SendKeys(unos3, false);
            IWebElement Tel = this.FindElement(By.XPath("//input[@name = 'telefon']"));
            string unos4 = "063256321";
            SendKeys(unos4, false);
            string selectByText = "Angola";
            IWebElement el = this.FindElement(By.Name("zemlja"));
            var select = new SelectElement(el);
            select.SelectByText(selectByText);
            this.FindElement(By.XPath("//input[@name = 'pol' and @value = 'z']"))?.Click();
            this.FindElement(By.XPath("//input[@name = 'obavestenja' and @value = '1']"))?.Click();
            this.FindElement(By.XPath("//input[@name = 'register']"))?.Click();
            IWebElement requerdElement = this.FindElement(By.XPath("//div[@class = 'alert alert-success']"));
            Assert.True(requerdElement.Displayed);
        }

        [Test]
        public void Test2_Ivica()
        {
            this.NavigateTo("http://test.qa.rs/");
            this.FindElement(By.XPath("//a[contains(text(),'Kreiraj novog korisnika')]"))?.Click();
            this.FindElement(By.Name("ime"))?.SendKeys("Pera");
            this.FindElement(By.Name("prezime"))?.SendKeys("Kojot");
            this.FindElement(By.Name("korisnicko"))?.SendKeys("Supergenije");
            this.FindElement(By.Name("email"))?.SendKeys("kvikkvik@run.com");
            this.FindElement(By.Name("telefon"))?.SendKeys("5252656");
            this.FindElement(By.Name("zemlja"));
            var zemlja = new SelectElement(this.WebElement);
            zemlja.SelectByText("Belize");

            this.FindElement(By.Id("pol_z"))?.Click();
            this.FindElement(By.Id("newsletter"))?.Click();
            this.FindElement(By.Name("register"))?.Submit();// Click();

            this.DoWait();

            this.FindElement(By.CssSelector("body:nth-child(2) div.alert.alert-success:nth-child(2) > strong:nth-child(1)"));

            if (this.WebElement.Text.Contains("Uspeh!"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }


        [Test]
        public void Test2_Aleksandar()
        {

            var driver = this.Driver;
            driver.Navigate().GoToUrl("http://test.qa.rs/new");
            DoWait(3);
            IWebElement ime = driver.FindElement(By.XPath("//input[@placeholder='Unesi ime']"));
            ime.SendKeys("Neko Ime");
            IWebElement prezime = driver.FindElement(By.XPath("//input[@placeholder='Unesi prezime']"));
            prezime.SendKeys("Neko prezime");
            IWebElement korisnickoIme = driver.FindElement(By.Name("korisnicko"));
            korisnickoIme.SendKeys("Neko korisnicko ime");
            IWebElement email = driver.FindElement(By.Name("email"));
            email.SendKeys("korisnik@email.com");
            IWebElement telefon = driver.FindElement(By.Name("telefon"));
            telefon.SendKeys("444-55-66");
            var zemlja = driver.FindElement(By.XPath("//select[@name='zemlja']"));
            var selectElement = new SelectElement(zemlja);
            selectElement.SelectByValue("bhs");
            IWebElement pol = driver.FindElement(By.XPath("//input[@id='pol_m']"));
            pol.Click();
            IWebElement news = driver.FindElement(By.XPath("//input[@id='newsletter']"));
            news.Click();
            IWebElement promo = driver.FindElement(By.XPath("//input[@id='promotions']"));
            promo.Click();
            IWebElement dugme = driver.FindElement(By.XPath("//input[@name='register']"));
            dugme.Click();
            IWebElement text = driver.FindElement(By.XPath("//div[@class='alert alert-success']"));

            if (text.Text.Contains("Uspeh!"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            this.DoWait(10);
        }

        [Test]
        public void Test2_Ivana()
        {
            this.NavigateTo("http://test.qa.rs/");
            this.DoWait(2);
            IWebElement novi = this.FindElement(By.XPath("//a[@href='/new']"));
            novi.Click();

            IWebElement ime = this.FindElement(By.Name("ime"));
            this.SendKeys("Ivana", false, ime);
            this.DoWait(1);
            IWebElement prezime = this.FindElement(By.Name("prezime"));
            this.SendKeys("Anris", false, prezime);
            this.DoWait(1);
            IWebElement korisnicko = this.FindElement(By.Name("korisnicko"));
            this.SendKeys("anris", false, korisnicko);
            this.DoWait(1);
            IWebElement email = this.FindElement(By.Name("email"));
            this.SendKeys("example@blabla.com", false, email);
            this.DoWait(1);
            IWebElement tel = this.FindElement(By.Name("telefon"));
            this.SendKeys("123456789", false, tel);
            this.DoWait(1);
            IWebElement drzava = this.FindElement(By.Name("zemlja"));
            var select = new SelectElement(drzava);
            select.SelectByValue("srb");
            this.DoWait(1);
            IWebElement pol = this.FindElement(By.Id("pol_z"));
            pol.Click();
            this.DoWait(1);
            IWebElement vesti = this.FindElement(By.Id("newsletter"));
            vesti.Click();
            this.DoWait(2);
            IWebElement registruj = this.FindElement(By.Name("register"));
            registruj.Click();
            this.DoWait(1);
            IWebElement uspeh = this.FindElement(By.XPath("//div[@class='alert alert-success']"));
            Assert.True(uspeh.Displayed);
            this.DoWait(3);
        }

        private void DismissCookieWarning()
        {
            // Dismisses cookie info message
            IWebElement cookie = this.FindElement(By.Id("cookie-law-info-bar"));
            cookie.FindElement(By.LinkText("ACCEPT"))?.Click();
        }

        private void DismissAdPopup()
        {
            this.FindElement(By.XPath("//img[@class='lazyloading']"))?.Click();
        }

        [Test, Category("Cas32")]
        public void TestRightClickContextMenu()
        {
            this.NavigateTo("https://www.cssscript.com/demo/lightweight-context-menu-library-class2context-js/");
            var action = new Actions(this.Driver);
            IWebElement div = this.FindElement(By.XPath("//div[contains(@class, 'class1')]"));
            action.ContextClick(div).Perform();
            DoWait(1);
            IWebElement a1 = this.FindElement(By.XPath("//a[contains(., 'A1')]"));
            a1.Click();
            DoWait(2);
            try
            {
                var alert = this.Driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch(NoAlertPresentException e)
            {
                // Do something
            }
            DoWait(2);
        }

        [Test, Category("Cas32")]
        public void TestScrollTo()
        {
            // Works in Chrome, doesn't work in Firefox
            this.NavigateTo("https://www.toolsqa.com/automation-practice-form/");
            DoWait(2);
            IWebElement continents = this.FindElement(By.Id("continents"));
            var action = new Actions(this.Driver);
            action.MoveToElement(continents).Perform();
            DoWait(2);
        }

        [Test]
        [Category("Cas32")]
        [MaxTime(60000)]
        public void TestDragAndDrop()
        {
            // Doesn't work
            this.NavigateTo("https://formy-project.herokuapp.com/dragdrop");
            IWebElement target = this.FindElement(By.Id("box"));
            IWebElement drop1 = this.FindElement(By.Id("image"));
            var action = new Actions(this.Driver);
            action.DragAndDrop(drop1, target).Perform();
            /*
            action.ClickAndHold(drop1);
            action.MoveToElement(target);
            action.Release();
            action.Build();
            action.Perform();
            */
            DoWait(2);
        }

        [Test, Category("Cas32")]
        public void TestWindows()
        {
            this.NavigateTo("https://www.seleniumeasy.com/test/window-popup-modal-demo.html");
            IWebElement twitter = this.FindElement(By.XPath("//a[contains(@class, 'followeasy') and contains(., 'Twitter')]"));
            twitter.Click();
            DoWait(1);
            var popup = this.Driver.WindowHandles[1];
            this.Driver.SwitchTo().Window(popup);
            // Executes in popup window
            DoWait(1);
            IWebElement username = this.FindElement(By.Id("username_or_email"));
            username.SendKeys("nekimail@negde.com");
            DoWait(1);
            IWebElement password = this.FindElement(By.Id("password"));
            password.SendKeys("nekasifra");
            DoWait(3);
            this.Driver.Close(); // Closes popup window

            DoWait(2);
            this.Driver.SwitchTo().Window(this.Driver.WindowHandles[0]);
        }

        [Test, Category("Cas32")]
        public void TestWaitForElement()
        {
            // Doesn't work
            this.NavigateTo("http://test.qa.rs");
            var findBy = By.XPath("//a[@href = '/new']");
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.FindElement(findBy));
            IWebElement link = this.FindElement(findBy);
            link.Click();
            DoWait(2);
        }

        [Test]
        [Category("Cas32")]
        public void Cas32_Aleksandar()
        {
            this.NavigateTo("https://www.seleniumeasy.com/test/window-popup-modal-demo.html");
            IWebElement button1 = this.FindElement(By.XPath("//div[@class='two-windows']/a"));
            //IWebElement button1 = this.FindElement(By.XPath("//a[contains(text(),'Follow Twitter & Facebook')]"));
            button1.Click();
            DoWait(1);
            var mainWindow = this.Driver.CurrentWindowHandle;

            foreach(var windowHandle in this.Driver.WindowHandles)
            {
                this.Driver.SwitchTo().Window(windowHandle);
                string title = this.Driver.Title;
                if (title.Contains("Twitter"))
                {
                    IWebElement username1 = this.FindElement(By.Id("username_or_email"));
                    username1.SendKeys("mail1@gmail.com");
                    DoWait(1);
                    IWebElement password1 = this.FindElement(By.XPath("//input[@id='password']"));
                    password1.SendKeys("sifra1");
                    DoWait(1);
                    this.Driver.Close();
                }
                if (title.Contains("Facebook"))
                {
                    IWebElement username2 = this.FindElement(By.CssSelector("#email"));
                    username2.SendKeys("mail2@gmail.com");
                    DoWait(1);
                    IWebElement password2 = this.FindElement(By.CssSelector("#pass"));
                    password2.SendKeys("sifra2");
                    DoWait(1);
                    this.Driver.Close();
                }
            }
            this.Driver.SwitchTo().Window(mainWindow);
        }


        [SetUp]
        public void SetUpTests()
        {
            this.Driver = new FirefoxDriver();
            //this.Driver = new ChromeDriver();
            this.Driver.Manage().Cookies.DeleteAllCookies();
            this.Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownTests()
        {
            this.Close();
        }
    }
}
