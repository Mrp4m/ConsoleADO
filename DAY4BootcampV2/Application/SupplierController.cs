using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    class SupplierController : ISupplier
    {
        TB_M_Suppliers suppliers = new TB_M_Suppliers();
        static MyContext myContext = new MyContext();
        bool status = false;
        int id;
        Validation valid = new Validation(myContext);

        public List<TB_M_Suppliers> Get()
        {
            var get = myContext.TB_M_Suppliers.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.Write(" " + list.id);
                Console.WriteLine(" " + list.Name);
            }
            return get;
        }

        public TB_M_Suppliers Get(int id)
        {
            Console.Write("Masukan ID : ");
            id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(id);
            return get;
        }

        public bool Insert(TB_M_Suppliers supplier)
        {
            //throw new NotImplementedException();
            string Name;
            Console.Write("Insert Name : ");
            Name = Console.ReadLine();
            suppliers.Name = Name;
            myContext.TB_M_Suppliers.Add(suppliers);
            //var result = (myContext.SaveChanges());
            //Validation valid = new Validation();
            return valid.validation();
        }

        public bool Update(TB_M_Suppliers supplier)
        {
            //throw new NotImplementedException();
            //TB_M_Suppliers getID = new TB_M_Suppliers();
            suppliers = Get(id);
            if (suppliers != null)
            {
                string Name;
                Console.Write("Insert Name : ");
                Name = Console.ReadLine();
                suppliers.Name = Name;
                myContext.Entry(suppliers).State = EntityState.Modified;
                //var result = (myContext.SaveChanges());
                //Validation valid = new Validation();
                return valid.validation();
            }
            else
            {
                Console.Write("ID Kosong");
            }

            return status;
        }

        public bool Delete()
        {
            //throw new NotImplementedException();
            suppliers = Get(id);
            if (suppliers != null)
            {
                myContext.Entry(suppliers).State = EntityState.Deleted;
                //var result = (myContext.SaveChanges());
                //Validation valid = new Validation();
                return valid.validation();
            }
            else
            {
                Console.Write("ID Kosong");
            }
            return status;
        }
    }
}
