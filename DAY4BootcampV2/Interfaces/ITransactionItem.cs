using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2.Interfaces
{
    interface ITransactionItem
    {
        List<TB_T_TransactionItems> Get();
        TB_T_TransactionItems Get(int id);
        bool Insert(TB_T_TransactionItems item);
        bool Update(int id, TB_T_TransactionItems item);
        bool Delete(int id);
    }
}
