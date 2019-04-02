using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    public interface ISupplier
    {
        List<TB_M_Suppliers> Get();
        TB_M_Suppliers Get(int id);
        bool Insert(TB_M_Suppliers supplier);
        bool Update(TB_M_Suppliers supplier);
        bool Delete();
    }
}
