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
System.Console.WriteLine($"qoshish:{birinchiSon + ikkinchiSon}");
System.Console.WriteLine($"Ayirish:{birinchiSon - ikkinchiSon}");
System.Console.Write($"bo\'lish:{birinchiSon / ikkinchiSon}");
System.Console.WriteLine($" |qoldiq:{birinchiSon % ikkinchiSon}");
System.Console.WriteLine($"kopaytirish:{birinchiSon * ikkinchiSon}");