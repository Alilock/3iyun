using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;

        public string Name
        {
            get { return _name; }
            set
            {
                bool check = false;
                if (value!=null&&Char.IsUpper(value[0]))
                {
                    for (int i = 1; i < value.Length; i++)
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                        }
                        else
                        {
                            check=false;
                            break;
                        }
                            

                }
                if (check)
                {
                    _name = value;
                }

            }
        }
        public string SurName
        {
            get { return _surname; }
            set
            { bool check  = false;
                if (value!=null&&Char.IsUpper(value[0]))
                {
                    for(int i = 1; i < value.Length; i++)
                        if (Char.IsLetter(value[i]))
                        {
                            check = true;
                        }
                   
                }
                if (check)
                {
                    _surname = value;
                }

            }

        }
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value>249)
                {
                    _salary = value;

                }
            }
        }

        
    }
}
