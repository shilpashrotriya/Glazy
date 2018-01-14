using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Glazy
{
    class Program
    {
        static void Main(string[] args)
        {
            Method obj = new Method();
            obj.DriverSetup();
            obj.Register();
            obj.Login();
            obj.Logout();

           
                  
     

            
             

           

        }
    }
}
