using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

System.Console.WriteLine("Asallomu alaykum mening kalkulyatorimga xush kelibsiz\niltimos quyidagi malumotlarni kiriting");


//ozgaruvchilarni elon qilamiz

decimal birinchiSon,ikkinchiSon;
string amallar;

//ozgaruvchilarni qabul qilib olamiz

System.Console.Write("birinchi sonni kiriting: ");
birinchiSon = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("bu sonlar ustida qanday amal bajarishingizki yozing\n\tsiz uchun qollanma");
System.Console.WriteLine("\n|*|/|+|-|%|");
amallar = Console.ReadLine();

System.Console.Write("ikkinchi sonni kiriting: ");
ikkinchiSon = Convert.ToDecimal(Console.ReadLine());

//arifmetik amallar switch expseesions yordamida

string result = amallar switch
{
    "+" => $"{birinchiSon} + {ikkinchiSon} = {birinchiSon + ikkinchiSon}",
    "-" => $"{birinchiSon} - {ikkinchiSon} = {birinchiSon - ikkinchiSon}",
    "/" => $"{birinchiSon} / {ikkinchiSon} = {birinchiSon / ikkinchiSon}",
    "*" => $"{birinchiSon} * {ikkinchiSon} = {birinchiSon * ikkinchiSon}",
    "%" => $"{birinchiSon} % {ikkinchiSon} = {birinchiSon % ikkinchiSon}",
    _   => "siz bunaqa amal yo\'q iltimos qayta urinib koring"
};

System.Console.WriteLine(result);

//arifmetik amallar switch operatori yozdamida

switch (amallar)
{
    case "*":
        System.Console.WriteLine($"{birinchiSon} * {ikkinchiSon} = {birinchiSon * ikkinchiSon}");
        break;
    case "+":
        System.Console.WriteLine($"{birinchiSon} + {ikkinchiSon} = {birinchiSon + ikkinchiSon}");
        break;
    case "/":
        System.Console.WriteLine($"{birinchiSon} / {ikkinchiSon} = {birinchiSon / ikkinchiSon}");
        break;
    case "-":
        System.Console.WriteLine($"{birinchiSon} - {ikkinchiSon} = {birinchiSon - ikkinchiSon}");
        break;
    case "%":
        System.Console.WriteLine($"{birinchiSon} % {ikkinchiSon} = {birinchiSon % ikkinchiSon}");
        break;
    default:
        System.Console.WriteLine("siz bunaqa amal yo\'q iltimos qayta urinib koring");
        break;
}


    //birinchi  son musbat yoki manfiy ekanligini ternar operatori orqali aniqlaymiz

string massage =
    birinchiSon >= 0
    ? "birinchi  son musbat "
    : "birinchi  son manfiy ";

    System.Console.WriteLine(massage);

    // ikkinchi son musbat yoki manfiy ekanligini ternar operatori orqali aniqlaymiz
string sonikki =
    ikkinchiSon >= 0
    ? "ikkinchi son musbat"
    : "ikkinchi son manfiy";

System.Console.WriteLine(sonikki);

    // ternar operatorlari yordamda taqqoslaymiz

string taqqosla =
    birinchiSon > ikkinchiSon
    ? "birinchi son ikkinchi sondan katta"
    : "birinchi son ikkinchi sondan kichik";
    System.Console.WriteLine(taqqosla);


for ( int itterator = 1; itterator <= 10; itterator++)
{
    for ( int inntterator = 1; inntterator <= 10;  inntterator++ )
    {
        Console.WriteLine($"{itterator} x {inntterator} = {itterator * inntterator}");
    }System.Console.WriteLine("\n");
    
}

