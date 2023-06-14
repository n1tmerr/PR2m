using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2m
{
    internal class stud: human
    {
        private Parent _parent;
        public stud(string name, int age, Pol pol, Parent parent) : base(name, age, pol)
        {
            _parent = parent;
        }
        public Parent Parent
        {
            get => _parent;
        }
        public string GetParent()
        {
            return _parent.Name;
        }
    }
}

