using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_4_Methods
{
    public class BankAccount
    {

        string _name;
        double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public double Balance { get => _balance; set => _balance = value; }




    } // class

} // namespace
