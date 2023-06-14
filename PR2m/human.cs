using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2m
{
    public enum Pol
    {
        M,
        W
    }
     class human
    {
        public string _name;
        private int _age;
        private Pol _pol;
        public human(string name, int age, Pol pol)
        {
            _name = name;
            _age = age;
            _pol = pol;
        }
        public string Name
        {
            get => _name;
        }
        public int Age
        { get => _age;

        }
        public Pol pol
        {
            get => _pol;
        }
    }
}
