using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class Student
    {
        //Question 1
        
        
        public int _id; //+_id:int
        public string _name; //+_name:string
        private string _phone; //-_phone:string
        private DateTime _dateofBirth; //-_dateofBirth:DateTime

                
       public Student(int i, string n, string hp, DateTime dob)
       {
            _id = i;
            _name = n;
            _phone = hp;
            _dateofBirth = dob;

        }




    }
}

