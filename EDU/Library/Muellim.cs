using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Muellim
    {
        public int id { get; private set; }
        private string name;
        private string sname;
        private int age;
        public Fenn[] fenn;
        protected double maas;
        public bool cins { get; private set; }
        public bool Cins
        {
            set { cins = value; }
        }

        public Muellim()
        {
            this.id = Tool.get_id();
            this.name = "Muellim";
            this.sname = "Muellim";
            this.age = 24;
            var f = new Fenn("Riyaziyyat");
            this.fenn = new Fenn[1] { f };

        }
        public Muellim(string name, string sname, int age, Fenn[] fenn, double maas, bool cins)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.fenn = fenn;
            this.maas = maas;
            this.cins = cins;

        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    name = "Test1";
                }

            }
        }
        public string Sname
        {
            get { return sname; }
            set
            {
                if (value.Length > 5)
                {
                    sname = value;
                }
                else
                {
                    sname = "Hemidli";
                }
            }

        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 23 && value <= 65)
                {
                    age = value;
                }
                else
                {
                    age = 23;
                }
            }
        }
        public double Maas
        {
            get { return maas; }
            set
            {
                if (value > 250 && value < 2800)
                {
                    maas = value;
                }
                else
                {
                    maas = 251;
                }
            }
        }
        public virtual double Get_gelir(double _bonus, double _gelir)
        {
            return maas + (_bonus * _gelir);
        }
        public virtual void Print()
        {
            string Gender = "Qadin";
            if (cins) Gender = "kisi";
            Console.WriteLine($"Muellim ID={id} Name={name} Surname={sname} Age={age}" +
                $"gender={Gender} gelir={maas} ");
            if (fenn.Length > 0)
            {
                Console.WriteLine("Kecdiyi fenler:");
                for (int i = 0; i < fenn.Length; i++)
                {
                    fenn[i].Print();
                }
            }

        }
    }
}
