using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2m
{
    internal class city
    {
        private string _name;
        private string _country;
        public city(string name)
        {
            _name = name;
            _country = "Россия";
        }
        public string Name
        {
            get => _name;
        }
        public string Country
        {
            get => _country;
        }
    }
}
