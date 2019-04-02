using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    class ItemController : IItem
    {
        static MyContext myContext = new MyContext();
        TB_M_Items items = new TB_M_Items();
        TB_M_Suppliers supplier = new TB_M_Suppliers();
        bool status = false;

        Validation valid = new Validation(myContext);
        //Supplier supplier = new Supplier();
        public bool Delete(int id)
        {
            //throw new NotImplementedException();
            if (Get(id) != null)
            {
                myContext.Entry(Get(id)).State = EntityState.Deleted;
                //var result = (myContext.SaveChanges());
               // Validation valid = new Validation();
                return valid.validation();
            }
            else
            {
                Console.Write("ID Kosong");
            }
            return status;
        }
        public List<TB_M_Items> Get()
        {
            var get = myContext.TB_M_Items.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.Write(" " + list.id);
                Console.WriteLine(" " + list.Name);
                Console.WriteLine(" " + list.Suppliers_id);
                Console.WriteLine(" " + list.Price);
                Console.WriteLine(" " + list.Stock);
            }
            return get;
            //throw new NotImplementedException();
        }

        public TB_M_Items Get(int id)
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Items.Find(id);
            return get;
        }

        public bool Insert(TB_M_Items items)
        {
            //throw new NotImplementedException();
            string Name;
            int id, Price, Stock;
            
            Console.Write("Insert Name : ");
            Name = Console.ReadLine();
            //Console.Write("Insert Supplier ID : ");
            //Supplier_id = Convert.ToInt16(Console.ReadLine());
            supplier = GetID();
            Console.Write("Insert Price : ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Stock : ");
            Stock = Convert.ToInt16(Console.ReadLine());

            if (supplier != null)
            {
                items.Name = Name;
                items.TB_M_Suppliers = supplier;
                items.Price = Price;
                items.Stock = Stock;

                myContext.TB_M_Items.Add(items);
                //var result = (myContext.SaveChanges());
                //Validation valid = new Validation();
                return valid.validation();
            } return status;
        }

        public bool Update(int id, TB_M_Items items)
        {
            //throw new NotImplementedException();
            
            if (Get(id) != null)
            {
                string Name;
                int Supplier_id, Price, Stock;

                Console.Write("Insert Name : ");
                Name = Console.ReadLine();
                Console.Write("Insert Supplier ID : ");
                Supplier_id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Insert Price : ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert Stock : ");
                Stock = Convert.ToInt16(Console.ReadLine());

                Get(id).Name = Name;
                Get(id).Suppliers_id = Supplier_id;
                Get(id).Price = Price;
                Get(id).Stock = Stock; 

                myContext.Entry(Get(id)).State = EntityState.Modified;
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

        public TB_M_Suppliers GetID()
        {
            //throw new NotImplementedException();
            Console.Write("Insert Supplier ID : ");
            int Supplier_id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Suppliers.Find(Supplier_id);

            return get;
        }
    }
}
