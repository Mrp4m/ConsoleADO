using DAY4BootcampV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4BootcampV2
{
    public interface IItem
    {
        List<TB_M_Items> Get();
        TB_M_Items Get(int id);
        bool Insert(TB_M_Items item);
        bool Update(TB_M_Items item);
        bool Delete();
    }
}
