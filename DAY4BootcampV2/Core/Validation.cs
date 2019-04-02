using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    class Validation
    {
        bool status = false;
        MyContext myContext = new MyContext();

        public Validation (MyContext _myContext)
        {
            myContext = _myContext;
        }

        //var result = Convert.ToBoolean(myContext.SaveChanges());
        public bool validation()
        {
            var result = (myContext.SaveChanges());
            if (result > 0)
            {
                Console.WriteLine("Succses");
                status = true;
            }
            else
            {
                Console.WriteLine("NotSuccses");
            }
            return status;
        }
    }
}
