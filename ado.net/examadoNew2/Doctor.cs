using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examadoNew2
{
    class Doctor
    {
        private int _id;
        private string _name;
        private string _qualification;
        private int _experience;
        private double _fees;

        public Doctor()
        {
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Qualification { get => _qualification; set => _qualification = value; }
        public double Fees { get => _fees; set => _fees = value; }
        public int Experience { get => _experience; set => _experience = value; }

        public Doctor(int _id, string _name, string _qualification, int _experience, double _fees)
        {
            this.Id = _id;
            this.Name = _name;
            this.Qualification = _qualification;
            this.Experience = _experience;
            this.Fees = _fees;
        }

        public Doctor(string _name, string _qualification, int _experience, double _fees)
        {
            this.Name = _name;
            this.Qualification = _qualification;
            this.Experience = _experience;
            this.Fees = _fees;
        }
    }
}
