using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Glazy
{
    class CtrlIDs
    { 
        // REGISTER VARIABLES
        public static string css_menuBtn = "svg[viewBox='0 0 24 10']";
        public static string xpath_loginReg = "//*[@id='Drawer']/div[1]/div/div/div[1]/div/div[2]/div/a";
        public static string xpath_signup = "//html/body/div/div/div/a[2]/img";
        public static string id_username = "UserName";
        public static string id_password = "Password";
        public static string id_confirmPass = "ConfirmPassword";
        public static string xpath_signupBtn = "/html/body/div/div/div/form/div[2]/div[2]/input";


        //LOGIN VARIABLES
        public static string id_email = "UserName";
        public static string id_password1 = "Password";
        public static string css_signIn = "input[value='Sign In']";


        //LOGOUT VARIABLES
        public static string css_menuBtn1 = "path[data-reactid='22']";
        public static string linktext_logout = "Logout";



       /* private static string email ;
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }*/
       




    }
}
