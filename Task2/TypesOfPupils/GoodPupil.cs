using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Read() { Console.WriteLine("Good reading skills"); }
        public override void Write() { Console.WriteLine("Good writing skills"); }
        public override void Study() { Console.WriteLine("Not really smart - just an average pupil"); }
        public override void Relax() { Console.WriteLine("Relaxing time to time"); }
    }
}
