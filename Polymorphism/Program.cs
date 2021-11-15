using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new ExcelentPupil();

            ClassRoom group = new ClassRoom(p1, p2); 

            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            group.Relax();

            Pupil p3 = new ExcelentPupil();
            Pupil p4 = p3;

            group = new ClassRoom(p1, p2, p3, p4);

            Console.WriteLine(new string('-', 30));
            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            group.Relax();

            Console.WriteLine(new string('-', 30));
            p1.Study();
            p2.Study();
            p3.Study();
            p4.Study();

            Console.ReadKey();

        }
    }

    class ClassRoom
    {
        Random rnd = new Random();
        List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(GeneratePupil());
            pupils.Add(GeneratePupil());
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
            pupils.Add(GeneratePupil());
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
            pupils.Add(pupil4);
        }

        private Pupil GeneratePupil()
        {
            int r = rnd.Next(1, 4);

            switch (r)  
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();  
            }
            return new BadPupil();
        }
        public void Study()
        {
            foreach (Pupil p in pupils)
            {
                p.Study(); 
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupils)
            {
                p.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupils)
            {
                p.Relax();
            }
        }

    }

    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil is read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil is write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relax");
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil is study");
        }

        public override void Read()
        {
            Console.WriteLine("ExcelentPupil is read");
        }

        public override void Write()
        {
            Console.WriteLine("ExcelentPupil is write");
        }

        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil is relax");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil is study");
        }

        public override void Read()
        {
            Console.WriteLine("GoodPupil is read");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil is write");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil is relax");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil is study");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil is read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil is write");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil is relax");
        }
    }
}
