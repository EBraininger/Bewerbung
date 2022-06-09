using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Password
    {
        string zeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzäöüÄÖÜß12345678910";
        public int passwortln;
        Random rnd = new Random();

        public Password(int passwortln)
        {
            this.passwortln = passwortln;
        }
        public string Generator(int passwortln)
        {
            string passwort = "";
            for (int i = 0; i <= passwortln; i++)
            {
                passwort += zeichen[rnd.Next(0, 68)];


            }
            return passwort;





        }
    }
}
