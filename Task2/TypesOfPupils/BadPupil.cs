using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadPupil : Pupil
    {
        public override void Read() { Console.WriteLine("Dont even understand what is letters"); }
        public override void Write() { Console.WriteLine("He didn't tried yet"); }
        public override void Study() { Console.WriteLine("Dumb AF"); }
        public override void Relax() { Console.WriteLine("Relaxing all day long"); }
    }
}
