using EDU.Library;

namespace EDU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fenn f = new Fenn();
            f.Print();
            Fenn f1 = new Fenn("Riyaziyyat");
            f1.Print();

            Muellim m1 = new Muellim();
            m1.Name = "Nihad";
            m1.Sname = "Izzetli";
            m1.Age = 34;
            m1.Cins = true;
            m1.Maas = 2333;
            m1.fenn = new Fenn[] { f, f1 };
            m1.Print();

            Teskilatci m = new Teskilatci();
            m.Name = "Mirmecid";
            m.Sname = "Hesimov";
            m.Age = 34;
            m.Cins = true;
            m.Maas = 5555;
            m.fenn = new Fenn[] { f, f1 };
            m.Print();

            Direktor m2 = new Direktor();
            m2.Name = "Mirmecid";
            m2.Sname = "Hesimov";
            m2.Age = 34;
            m2.Cins = true;
            m2.Maas = 5555;
            m2.fenn = new Fenn[] { f };
            m2.Print();

        }
    }
}
