using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class Security
    {
        public void parolniOtkaz()
        {
            string  parol;
            do
            {
                
                System.Console.WriteLine("parol: ");
                parol = Console.ReadLine();
            }while (parol != "password");
        }
    }
}