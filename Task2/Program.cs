using System;

namespace Task2
{
    class Program
    {
        private static int read =0 ;
        private int write;
        private int study;
        private int relax;

        private static  int number;
        public static void Main(string[] args)
        {
            Pupil one = new ExcelentPupil();
            Pupil two = new BadPupil();
            Pupil three = new GoodPupil();
            Pupil four = new GoodPupil();

            Console.WriteLine("Classroom No1:");
            ClassRoom firstClass = new ClassRoom(one, two, three, four);
            Console.WriteLine("\nClassroom No2:");
            ClassRoom secondClass = new ClassRoom(one, two, three);
            Console.WriteLine("\nClassroom No3:");
            ClassRoom thirdClass = new ClassRoom(one, two);

            
        }

        
    }
}
