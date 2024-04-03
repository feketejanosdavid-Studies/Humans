using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansData.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; } 
        public string Address { get; set; } 
        public string Job { get; set; } 
        public string Hobby { get; set; }

        public Human()
        {
        }

        public Human(string line)
        {
            string[] parts = line.Split(";");
            Name = parts[0];
            Age = Convert.ToInt32(parts[1]);
            Address = parts[2];
            Job = parts[3];
            Hobby = parts[4];
        }

        public override string? ToString()
        {
            return $"A nevem {Name}, {Job} a munkám, Szabadidőmben ezeket csinálom: {Hobby}.";
        }
    }
}
