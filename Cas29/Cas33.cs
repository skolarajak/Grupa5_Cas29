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
    class Cas33:SeleniumBaseClass
    {

        [Test]
        [Category("Cas33")]
        public void Test_Ivica()
        {
            this.NavigateTo("http://test.qa.rs/");

            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(13));

            wait.Until(drv => drv.FindElement(By.LinkText("Kreiraj novog korisnika")));

            this.FindElement(By.LinkText("Kreiraj novog korisnika"))?.Click();

            this.FindElement(By.Name("ime"))?.SendKeys("Mihajlo");
            this.FindElement(By.Name("prezime"))?.SendKeys("Pupin");
            this.FindElement(By.Name("korisnicko"))?.SendKeys("Pupin2020");
            this.FindElement(By.Name("email"))?.SendKeys("Pupin2020@mail.com");
            this.FindElement(By.Name("telefon"))?.SendKeys("51651616");
            this.FindElement(By.Id("zemlja"));

            var zemlja = new SelectElement(this.WebElement);

            zemlja.SelectByText("Sudan");

            wait.Until(drv => drv.FindElement(By.Id("grad")));
            this.FindElement(By.Id("grad"));
            var grad = new SelectElement(this.WebElement);

            grad.SelectByText("Berber");

            this.FindElement(By.XPath("//div[contains(text(),'Ulica i broj')]//following::input[@size='40']"))?.SendKeys("Kockasta bb");

            this.FindElement(By.XPath("//input[@id='pol_m']"))?.Click();
            this.FindElement(By.XPath("//input[@id='promotions']"))?.Click();
            this.FindElement(By.XPath("//input[@name='register']"))?.Click();
        }

        [Test]
        [Category("Cas33")]
        public void Test_Ivana()
        {
            this.NavigateTo("http://test.qa.rs/");
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(20));
            wait.Until(c => c.FindElement(By.XPath("//div[@id='registerLinkPlaceholder']/a")));
            this.DoWait(1);
            IWebElement registerNew = this.FindElement(By.XPath("//div[@id='registerLinkPlaceholder']/a"));
            registerNew.Click();
            this.DoWait(1);
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
            IWebElement ulica = this.FindElement(By.XPath("(//div[@id='address']/div)[2]/input"));
            this.SendKeys("Bul Oslobojenja 123", false, ulica);
            this.DoWait(1);
            IWebElement drzava = this.FindElement(By.Name("zemlja"));
            var select = new SelectElement(drzava);
            select.SelectByValue("srb");
            this.DoWait(1);
            wait.Until(c => c.FindElement(By.Id("grad")));
            this.DoWait(1);
            IWebElement grad = this.FindElement(By.Id("grad"));
            select = new SelectElement(grad);
            select.SelectByIndex(9);
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

        [Test]
        [Category("Cas33")]
        public void Test_Aleksandar()
        {

            this.NavigateTo("http://test.qa.rs");
            var findBy = By.XPath("//a[contains(text(),'Kreiraj novog korisnika')]");
            var wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(20));
            wait.Until(drv => drv.FindElement(findBy));
            IWebElement link = this.FindElement(findBy);
            link.Click();

            IWebElement ime = this.FindElement(By.XPath("//input[@name='ime']"));
            ime.SendKeys("Marko");

            IWebElement prezime = this.FindElement(By.XPath("//input[@name='prezime']"));
            prezime.SendKeys("Markovic");

            IWebElement korisnicko = this.FindElement(By.XPath("//input[@name='korisnicko']"));
            korisnicko.SendKeys("MMarkovic");

            IWebElement email = this.FindElement(By.XPath("//input[@name='email']"));
            email.SendKeys("markovic@gmail.com");

            IWebElement telefon = this.FindElement(By.XPath("//input[@name='telefon']"));
            telefon.SendKeys("06111001100");

            IWebElement izaberiZemlju = this.FindElement(By.Name("zemlja"));
            var select = new SelectElement(izaberiZemlju);
            select.SelectByValue("srb");

            var findBy2 = By.XPath("//select[@id='grad']");
            var wait2 = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(20));
            wait2.Until(drv => drv.FindElement(findBy2));

            IWebElement izaberiGrad = this.FindElement(findBy2);
            var selectgrad = new SelectElement(izaberiGrad);
            selectgrad.SelectByValue("Niš");

            IWebElement ulica = this.FindElement(By.XPath("//form[1]/div[8]/div[2]/input[1]"));
            ulica.SendKeys("Neznanog Junaka 2");

            IWebElement pol = this.FindElement(By.XPath("//input[@id='pol_m']"));
            pol.Click();

            IWebElement cekbox1 = this.FindElement(By.Id("newsletter"));
            cekbox1.Click();

            IWebElement cekbox2 = this.FindElement(By.Id("promotions"));
            cekbox2.Click();

            IWebElement button = this.FindElement(By.XPath("//input[@name='register']"));
            button.Submit();
        }

        [Test]
        [Category("Cas33")]
        public void ShoppingCart_Aleksandar()
        {
            this.NavigateTo("http://shop.qa.rs/");

            IWebElement vrednost = this.FindElement(By.XPath("//div[@class='panel panel-info']//select[@name='quantity']"));
            var desetka = new SelectElement(vrednost);
            desetka.SelectByValue("10");

            // Problem je u ovom redu, postoji vise dugmica sa ovom klasom
            // + ClassName ne prihvata razmak, odnosno, koriscenje vise klasa kao parametar
            // Ovde bi vise odgovarao selektor By.XPath
            //this.FindElement(By.ClassName("btn btn-primary'"))?.Click();
            this.FindElement(By.XPath("//h3[contains(text(),'PRO')]/parent::div/following-sibling::div[1]//input[@type='submit']"))?.Click();

            IWebElement totalPrice = this.FindElement(By.XPath("//table[1]/tbody[1]/tr[3]/td[1]"));

            string selectedItem = totalPrice.Text.Substring(8);
            string expectedItem = "8000";
            // ^ vrednost je hardkodovana, pa kao takva, nije validan test
            // Pogledati npr u ShoppingCart_Ivana, kako izracunati koja je
            // ocekivana vrednost, a koja je dobijena.

            Assert.AreEqual(selectedItem, expectedItem, "Selected item doesn't match expected.");
        }

        [Test]
        [Category("Cas33")]
        public void ShoppingCart_Ivana()
        {
            this.NavigateTo("http://shop.qa.rs/");
            IWebElement kolicina = this.FindElement(By.XPath("//h3[contains(text(),'PRO')]/parent::div/following-sibling::div[1]//select"));
            var select = new SelectElement(kolicina);
            select.SelectByValue("10");
            this.DoWait(1);
            IWebElement order = this.FindElement(By.XPath("//h3[contains(text(),'PRO')]/parent::div/following-sibling::div[1]//input[@type='submit']"));
            order.Click();

            int qty = Convert.ToInt32(this.FindElement(By.XPath("(//table//td)[2]")).Text);
            int price = Convert.ToInt32(this.FindElement(By.XPath("(//table//td)[3]")).Text.Substring(1));
            int subtotal = Convert.ToInt32(this.FindElement(By.XPath("(//table//td)[4]")).Text.Substring(1));

            Assert.AreEqual(qty * price, subtotal);

            this.DoWait(3);
        }

        [Test]
        [Category("Cas33")]
        public void ShoppingCart_Filip()
        {
            this.NavigateTo("http://shop.qa.rs/");
            DoWait(2);

            IWebElement pro = this.FindElement(By.XPath("(//select[@name='quantity'])[3]"));
            var selection = new SelectElement(pro);
            selection.SelectByValue("10");
            DoWait(2);
            this.FindElement(By.XPath("(//input[@type='submit' and @value='ORDER NOW'])[3]"))?.Click();
            DoWait(2);
            IWebElement quantity = this.FindElement(By.XPath("//tbody//tr[1]/td[2]"));
            IWebElement ppi = this.FindElement(By.XPath("//tbody//tr[1]/td[3]"));

            IWebElement total = this.FindElement(By.XPath("//tbody//tr[1]/td[4]"));
            DoWait(2);
            string q1 = quantity.Text;
            int q2 = Convert.ToInt32(q1);
            string p1 = ppi.Text.Substring(1); // Falilo je .Substring(1)
            int p2 = Convert.ToInt32(p1);
            string t1 = ppi.Text.Substring(1); // Falilo je .Substring(1)
            int t2 = Convert.ToInt32(t1);

            if (q2 * p2 == t2)
            {
                Assert.Pass("Prosao");

            }
            else
                Assert.Fail("Nije");
        }

        [Test]
        [Category("Cas33")]
        public void ShoppingCart_Ivica()
        {
            this.NavigateTo("http://shop.qa.rs/");

            this.FindElement(By.XPath("//div[@class='panel panel-info']//select[@name='quantity']"));

            var kol = new SelectElement(this.WebElement);
            kol.SelectByValue("10");

            this.FindElement(By.XPath("//div[@class='panel panel-info']//input[@class='btn btn-primary']"))?.Click();
            var totalItemPrice = Convert.ToInt32(this.FindElement(By.XPath("//tr[1]//td[4]")).Text.Substring(1));

            //var cenaUkupno = totalItemPrice.Substring(1, totalItemPrice.Length);

            var pricePerItem = Convert.ToInt32(this.FindElement(By.XPath("//tr[1]//td[3]")).Text.Substring(1));

            //var cenaPoJedinici = ricePerItem.Substring(1, totalItemPrice.Length);

            var quantity = Convert.ToInt32(this.FindElement(By.XPath("//tr[1]//td[2]")).Text);

            var total = Convert.ToInt32(this.FindElement(By.XPath("//tr[3]")).Text.Substring(8)); // Falilo je .Substring(8)

            if (totalItemPrice == (pricePerItem * quantity))
            {
                if (totalItemPrice == total)
                {
                    Assert.Pass();
                }
            }
            else
            {
                Assert.Fail();
            }
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
