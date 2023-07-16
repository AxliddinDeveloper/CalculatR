using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class Calculator
    {
        public decimal birinchiSon { get; set; }
        public string amallar { get; set; }
        public string result { get; set; }
        public decimal ikkinchiSon { get; set; }
        public string savol { get; set; }
        public void sonlarniQabulQilish()
        {
            System.Console.Write("birinchi sonni kiriting: ");
            birinchiSon = Convert.ToDecimal(Console.ReadLine());

            System.Console.WriteLine("bu sonlar ustida qanday amal bajarishingizki yozing\n\tsiz uchun qollanma");
            System.Console.WriteLine("\n|*|/|+|-|%|");
            amallar = Console.ReadLine();

            System.Console.Write("ikkinchi sonni kiriting: ");
            ikkinchiSon = Convert.ToDecimal(Console.ReadLine());
        }
        public string  sonlarUstidaAmallar()
        {
            return  result = amallar switch
            {
                "+" => $"{birinchiSon} + {ikkinchiSon} = {birinchiSon + ikkinchiSon}",
                "-" => $"{birinchiSon} - {ikkinchiSon} = {birinchiSon - ikkinchiSon}",
                "/" => $"{birinchiSon} / {ikkinchiSon} = {birinchiSon / ikkinchiSon}",
                "*" => $"{birinchiSon} * {ikkinchiSon} = {birinchiSon * ikkinchiSon}",
                "%" => $"{birinchiSon} % {ikkinchiSon} = {birinchiSon % ikkinchiSon}",
                _   => "kechirasiz bunaqa amal yo\'q iltimos qayta urinib koring"
            };

                    Console.WriteLine(result);
        }
        public void sonlarniTaqqosla()
        {
            System.Console.Write("ikki sonni taqqoslashni hohlaysizmi? ");
            savol = Convert.ToString(Console.ReadLine());
            if (savol == "ha")
            {
                string taqqosla =
                birinchiSon > ikkinchiSon
                ? "birinchi son ikkinchi sondan katta"
                : "birinchi son ikkinchi sondan kichik";
                System.Console.WriteLine(taqqosla);
            }
            else
            {
                System.Console.WriteLine("");
            }
        }
        public bool birinchiSonMusbatYokiManfiyligi()
        {
                return birinchiSon >= 0;
        }
        public bool ikkinchiSonMusbatYokiManfiyligi()
        {
                return ikkinchiSon >= 0;
        }
        public void karaJadvali()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1;  j <= 10; j++)
                {
                    System.Console.WriteLine($"{i} x {j} = {i*j}");
                }
                System.Console.WriteLine("");
            }
        }


    }
}