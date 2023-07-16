using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using CalculatR.Classes;

namespace CalculatR
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Asallomu alaykum mening kalkulyatorimga xush kelibsiz\niltimos quyidagi malumotlarni kiriting");

            Security security = new Security();
            Calculator calculator = new Calculator();

            //parol
            security.parolniOtkaz();
            
            //consoledan ozgaruvchilarni qabul qilib olamiz
            calculator.sonlarniQabulQilish();

            //ozgaruvchilar ustida amallar qilamiz
            calculator.sonlarUstidaAmallar();

            //  sonlarni  musbat yoki manfiy ekanligini ternar operatori orqali aniqlaymiz
            calculator.birinchiSonMusbatYokiManfiyligi();
            string sonBir =
            (calculator.birinchiSonMusbatYokiManfiyligi())
            ? "birinchi son musbat"
            : "birinchi son manfiy";
            System.Console.WriteLine(sonBir);
            string sonIkki =
            (calculator.ikkinchiSonMusbatYokiManfiyligi())
            ? "ikkinchi son musbat"
            : "ikkinchi son manfiy";
            System.Console.WriteLine(sonIkki);

            //sonlarni taqqoslash
            calculator.sonlarniTaqqosla();

            //kara jadvali
            calculator.karaJadvali();
            
        }

    }
}
