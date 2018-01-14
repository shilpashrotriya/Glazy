using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Glazy
{
    class Input
    {
        // private static void Rand ()
        // {
        //   Random random = new Random();
        // private int randomint = random.Next(1000);
        // }

        /* public int Randomint
        {
            get { return randomint; }

            set { randomint = value; }
        }*/

        //private static string input_username = "shilpa.joshi"+Rand()+"@gmail.com";

        //public static string Input_username { get => input_username; set => input_username = value; }



        // REGISTER INPUTS
        public static Random randomGenerator = new Random();
        public static int randomint = randomGenerator.Next(1000);
        public static string input_username = "shilpa.joshi" + randomint + "@gmail.com";
        public static string input_password = "Neev$14";


             // LOGIN INPUTS
        public static string input_email = "ershilpashrotriya@gmail.com";
        public static string input_password1 = "omsairam";
    }
}
