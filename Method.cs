using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;





namespace Glazy
{
    class Method
    {
        IWebDriver driver = new ChromeDriver();
        

        public void DriverSetup()

        {
            
            driver.Url = "http://test-gp.classifiedsolutionsgroup.com/";

        }
            

        public void Register()
        {
           

            Thread.Sleep(3000);
            var menu_button = driver.FindElement(By.CssSelector(CtrlIDs.css_menuBtn));       //clicking on menu button to register
            menu_button.Click();
            Thread.Sleep(2000);
            var login_reg = driver.FindElement(By.XPath(CtrlIDs.xpath_loginReg));
             login_reg.Click();

             Thread.Sleep(3000);
             var signup = driver.FindElement(By.XPath(CtrlIDs.xpath_signup));          //registering user form
             signup.Click();
             Thread.Sleep(3000);
             var username = driver.FindElement(By.Id(CtrlIDs.id_username));
             username.SendKeys(Input.input_username);
             var password = driver.FindElement(By.Id(CtrlIDs.id_password));
             password.SendKeys(Input.input_password);
             var confirm_pass = driver.FindElement(By.Id(CtrlIDs.id_confirmPass));
             confirm_pass.SendKeys(Input.input_password);
             var signup_button = driver.FindElement(By.XPath(CtrlIDs.xpath_signupBtn));
             signup_button.Click();
        }

        public void Login()
        {
            Thread.Sleep(5000);
             var email = driver.FindElement(By.Id(CtrlIDs.id_email));                              // sign in using valid email & password
            email.Clear();
            email.SendKeys(Input.input_email);
            var password1 = driver.FindElement(By.Id(CtrlIDs.id_password1));
            password1.SendKeys(Input.input_password1);
            var sign_button = driver.FindElement(By.CssSelector(CtrlIDs.css_signIn));
             sign_button.Click();
        }
       
            public void Logout()
        {
            Thread.Sleep(3000);
            var menu_button1 = driver.FindElement(By.CssSelector(CtrlIDs.css_menuBtn1));       // logout
            menu_button1.Click();
            var logout = driver.FindElement(By.LinkText(CtrlIDs.linktext_logout));
            logout.Click(); 
        }
    }
}
