using HumansData.Data;
using System.ComponentModel.Design;

var sorok = File.ReadAllLines(@"c:\Users\Diak\..fjd\Második_félév\asztali_alkalmazasok\2024-04-03\7.csv").Skip(1);


HumanContext context = new HumanContext();
if (!context.Humans.Any())
{
    foreach (var s in sorok)
    {
        context.Humans.Add(new HumansData.Models.Human(s));
    }
    context.SaveChanges();
    foreach (var s in context.Humans) Console.WriteLine(s);
}

else
{
    Console.WriteLine("Az adattábla már tartalmaz adatokat!");
}