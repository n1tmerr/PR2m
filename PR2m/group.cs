using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PR2m
{
    internal class group
    {
        private List<stud> _studs;
        private city _city;
        private string _name;
        public group(List<stud> studs, city city, string name)
        {
            _studs = studs;
            _city = city;
            _name = name;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string city
        {
            get => _city.Name;
        }
        public city City1 { get => _city; }

        public int CountStuds
        {
            get => _studs.Count;
        }
        public List<stud> studs
        {
            get => _studs;
        }
    }
}

