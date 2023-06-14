using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PR2m
{
    internal class db
    {
        private Random _rand = new Random();
        internal List<group> gruppa { get; private set; }
        public db()

        {
            List<stud> studs = new List<stud>()//Студенты первой группы
            {
                new stud("Костя",17,Pol.M,new Parent("Валера",_rand.Next(21,70),Pol.M)),
                new stud ("Настя",17,Pol.W,new Parent("Дима",_rand.Next(21,70),Pol.M)),
                new stud("Витя",18,Pol.M,new Parent("Михаил",_rand.Next(21,70),Pol.M)),
                new stud("Женя",18,Pol.M,new Parent("Марина",_rand.Next(21,70),Pol.W))
            };


            List<stud> studs1 = new List<stud>()//Студенты второй группы
            {
                new stud("Дима",17,Pol.M,new Parent("Оля",_rand.Next(21,70),Pol.W)),
                new stud ("Витя",16,Pol.M,new Parent("Валя",_rand.Next(21,70),Pol.W)),
                new stud("Даниил",18,Pol.M,new Parent("Наташа",_rand.Next(21,70),Pol.W)),
                new stud("Михаил",17,Pol.M,new Parent("Марина",_rand.Next(21,70),Pol.W)),
                new stud("Женя",16,Pol.M,new Parent("Олу",_rand.Next(21,70),Pol.W))
            };


            gruppa = new List<group>()
            {
                new group(studs,new city("Абакан"),"ПРО-32"),
                new group(studs1,new city("Абакан"),"ПРО-31")

            };
        }
    }
}
