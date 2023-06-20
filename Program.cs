using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

System.Console.WriteLine("Asallomu alaykum mening kalkulyatorimga xush kelibsiz\niltimos quyidagi malumotlarni kiriting");
//ozgaruvchilarni elon qilamiz
decimal birinchiSon;
decimal ikkinchiSon;
//ozgaruvchilarni qabul qilib olamiz
System.Console.Write("birinchi sonni kiriting: ");
birinchiSon = Convert.ToDecimal(Console.ReadLine());
System.Console.Write("ikkinchi sonni kiriting: ");
ikkinchiSon = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine($"birinchi sonni ikkinchi songa qoshsa:{birinchiSon + ikkinchiSon}");
System.Console.WriteLine($"birinchi sondan ikkinchi sonni Ayirsa:{birinchiSon - ikkinchiSon}");
System.Console.Write($"birinchi sonni ikkinchi songa bo\'lsa:{birinchiSon / ikkinchiSon}");
System.Console.WriteLine($" |qoldiq:{birinchiSon % ikkinchiSon}");
System.Console.WriteLine($"birinchi sonni ikkinchi songa kopaytirsa:{birinchiSon * ikkinchiSon}");
if (birinchiSon > ikkinchiSon)
{
    System.Console.WriteLine("birinchi son ikkinchi sondan katta!");
}else if (birinchiSon == ikkinchiSon)
{
    System.Console.WriteLine("birinchi son ikkinchi songa teng!");
}
else
{
    System.Console.WriteLine("birinchi son ikkinchi sondan kichik!");
}