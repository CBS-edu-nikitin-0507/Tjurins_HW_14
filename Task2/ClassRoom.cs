using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        public ClassRoom(Pupil one,Pupil two, Pupil three, Pupil four) 
        {
            Console.WriteLine("Pupil No1:");
            one.Read();
            one.Write();
            one.Study();
            one.Relax();

            Console.WriteLine("\nPupil No2:");
            two.Read();
            two.Write();
            two.Study();
            two.Relax();

            Console.WriteLine("\nPupil No3:");
            three.Read();
            three.Write();
            three.Study();
            three.Relax();

            Console.WriteLine("\nPupil No4:");
            four.Read();
            four.Write();
            four.Study();
            four.Relax();


        }
        public ClassRoom(Pupil one, Pupil two, Pupil three)
        {
            Console.WriteLine("Pupil No1:");
            one.Read();
            one.Write();
            one.Study();
            one.Relax();

            Console.WriteLine("\nPupil No2:");
            two.Read();
            two.Write();
            two.Study();
            two.Relax();

            Console.WriteLine("\nPupil No3:");
            three.Read();
            three.Write();
            three.Study();
            three.Relax();
        }
        public ClassRoom(Pupil one, Pupil two)
        {
            Console.WriteLine("Pupil No1:");
            one.Read();
            one.Write();
            one.Study();
            one.Relax();

            Console.WriteLine("\nPupil No2:");
            two.Read();
            two.Write();
            two.Study();
            two.Relax();
        }
    }

}
