using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO3
{
    class ItemType
    {
        private int _id;
        private string _name;
        private double _deposit;
        private double _costPerDay;
        public ItemType(int _id, string _name, double _deposit, double _costPerDay)
        {
            this._id = _id;
            this._name = _name;
            this._deposit = _deposit;
            this._costPerDay = _costPerDay;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Deposit
        {
            get
            {
                return _deposit;
            }
            set
            {
                _deposit = value;
            }
        }
        public double CostPerDay
        {
            get
            {
                return _costPerDay;
            }
            set
            {
                _costPerDay = value;
            }
        }
    }

}
