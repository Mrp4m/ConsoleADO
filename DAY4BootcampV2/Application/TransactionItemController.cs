using DAY4BootcampV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAY4BootcampV2.Models;
using DAY4BootcampV2.ViewModels;

namespace DAY4BootcampV2.Application
{
    class TransactionItemController : ITransactionItem
    {
        SellController sellController = new SellController();
        static MyContext myContext = new MyContext();
        TB_T_TransactionItems transactionItem = new TB_T_TransactionItems();
        TB_M_Sells sells = new TB_M_Sells();
        ISell iSell = new SellController();
        Validation valid = new Validation(myContext);

        bool status = false;
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_T_TransactionItems> Get()
        {
            //throw new NotImplementedException();
            return myContext.TB_T_TransactionItems.ToList();
        }

        public TB_T_TransactionItems Get(int id)
        {
            //throw new NotImplementedException();
            return myContext.TB_T_TransactionItems.SingleOrDefault(x => x.Id == id);
        }

        public bool Insert(TB_T_TransactionItems item)
        {
            //throw new NotImplementedException();
            string Name;
            int Quantity, item_id, sell_id;
            string date;
            sells.OrderDate = DateTime.Now;
            iSell.Insert(sells);

            Console.Write("Insert Quantity : ");
            Quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Item ID : ");
            item_id = Convert.ToInt32(Console.ReadLine());
            sell_id = sells.Id;

            transactionItem.Quantity = Quantity;
            transactionItem.TB_M_Items_id = item_id;
            transactionItem.TB_M_Sells_id = sell_id;

            myContext.TB_T_TransactionItems.Add(transactionItem);
            //var result = (myContext.SaveChanges());

            return valid.validation();
        }

        public bool Update(int id, TB_T_TransactionItems item)
        {
            throw new NotImplementedException();
        }
    }
}
