using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Read() { Console.WriteLine("Excelent reading skills"); }
        public override void Write() { Console.WriteLine("Excelent writing skills"); }
        public override void Study() { Console.WriteLine("Smart"); }
        public override void Relax() { Console.WriteLine("Have no time to relax"); }
    }
}
