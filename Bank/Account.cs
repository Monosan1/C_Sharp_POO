using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
    {
    class Account
        {
        public int Acc_Number { get; private set; }
        public double Amount { get; private set; }

        private string _name;

        public string Name
            {

            get { return _name; }
            set {
                _name = value;
                }
            }



        }
    }