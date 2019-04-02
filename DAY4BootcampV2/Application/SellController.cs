using DAY4BootcampV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAY4BootcampV2.Models;

namespace DAY4BootcampV2.Application
{
    class SellController : ISell
    {
        static MyContext myContext = new MyContext();
        TB_M_Sells sells = new TB_M_Sells();
        Validation valid = new Validation(myContext);
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_Sells> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Sells.ToList();
            foreach (var list in get)
            {
                Console.Write(" " + list.Id);
                Console.WriteLine(" " + list.OrderDate);
            }
            return get;
        }

        public TB_M_Sells Get(int id)
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Sells.Find(id);
            return get;
        }

        public bool Insert(TB_M_Sells sells)
        {
            //throw new NotImplementedException();
            {
                //throw new NotImplementedException();
                myContext.TB_M_Sells.Add(sells);
                //var result = myContext.SaveChanges();
                //Validation valid = new Validation();
                return valid.validation();
            }
        }

        public bool Update(int id, TB_M_Sells item)
        {
            throw new NotImplementedException();
        }
    }
}
